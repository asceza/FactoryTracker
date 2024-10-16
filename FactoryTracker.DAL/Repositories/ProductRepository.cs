using FactoryTracker.DAL.Interfaces;
using FactoryTracker.DAL.Models;
using FactoryTracker.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;

namespace FactoryTracker.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Dictionary<int, Product> _products;

        public ProductRepository()
        {
            _products = new Dictionary<int, Product>();
        }

        private int IncrementProductId()
        {
            if (_products.Count == 0)
            {
                return 1;
            }
            else
            {
                return _products.MaxBy(k => k.Key).Key + 1;
            }
        }


        //public bool AddProduct(Product product)
        //{
        //    try
        //    {
        //        int id = IncrementProductId();
        //        product.ID = id;
        //        _products.Add(id, product);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return false;
        //    }
        //}

        public Result<bool> AddProduct(Product product)
        {

            int id = IncrementProductId();
            product.ID = id;
            if (_products.TryAdd(id, product))
            {
                return new Result<bool>(true);
            }
            else
            {
                return new Result<bool>("Продукт не был добавлен");
            }
        }


        //public Product GetProduct(string productNumber)
        //{
        //    try
        //    {
        //        var foundProduct = _products.FirstOrDefault(item => item.Value.Number == productNumber).Value;
        //        if (foundProduct != null)
        //        {
        //            return foundProduct;
        //        }
        //        else
        //        {
        //            throw new Exception($"В словаре _products нет значения с номером {productNumber}");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Ошибка {ex.Message}");
        //    }
        //}

        public Result<Product> GetProduct(string productNumber)
        {
            try
            {
                var foundProduct = _products.FirstOrDefault(item => item.Value.Number == productNumber).Value;
                if (foundProduct != null)
                {
                    return new Result<Product>(foundProduct);
                }
                else
                {
                    return new Result<Product>($"В словаре _products нет значения с номером {productNumber}");
                }
            }
            catch (Exception ex)
            {
                //throw new Exception($"Ошибка {ex.Message}");
                return new Result<Product>($"Ошибка {ex.Message}");
            }
        }


        public Product[] GetAllProducts()
        {
            var allProducts = _products.Values.ToArray();
            return allProducts;
        }
    }
}
