using FactoryTracker.DAL.Interfaces;
using FactoryTracker.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public bool AddProduct(Product product)
        {
            try
            {
                int id = IncrementProductId();
                product.ID = id;
                _products.Add(id, product);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        // изменить поиск по number -> поменять Dictionary<string, Product>??
        public Product GetProduct(int productId)
        {
            try
            {
                KeyValuePair<int, Product> foundItem = _products.First(item => item.Key == productId);
                if (!foundItem.Equals(new KeyValuePair<int, Product>()))
                {
                    return foundItem.Value;
                }
                else
                {
                    throw new Exception($"В словаре _products нет значения с ключом {productId}");
                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка {ex.Message}");
            }
        }


        public Product[] GetAllProducts()
        {
            var allProducts = _products.Values.ToArray();
            return allProducts;
        }
    }
}
