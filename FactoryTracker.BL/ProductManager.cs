using FactoryTracker.DAL.Interfaces;
using FactoryTracker.DAL.Models;
using FactoryTracker.DAL.Repositories;
using FactoryTracker.Core.Enums;
using FactoryTracker.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker.BL
{
    public class ProductManager
    {
        private readonly IProductRepository _productRepository;
        public ProductManager()
        {
            _productRepository = new ProductRepository();
        }

        public bool AddNewProduct(string number)
        {
            var product = new Product()
            {
                Number = number,
                ProductStatus = ProductStatus.Unknown,
            };

            bool isProductAdded = _productRepository.AddProduct(product);
            
            // сделать проверка try???
            return isProductAdded;

        }


        public IEnumerable<string> GetAllProductNumbers()
        {
            // логика внутри DAL - дай нам все
            var allProducts = _productRepository.GetAllProducts();
            var allProductsNumber = allProducts.Select(i => i.Number);
            return allProductsNumber;
        }


        //public Product GetProductByNumber(string selectedProductNumber)
        //{
        //    var allProducts = _productRepository.GetAllProducts();
        //    Product product = allProducts.First(p => p.Number == selectedProductNumber);
        //    return product;
        //}


        public Product GetProductByNumber(string selectedProductNumber)
        {
            var product = _productRepository.GetProduct(selectedProductNumber);
            return product;
        }


        public bool SetStatusForProduct(Product product, ProductStatus productStatus)
        {
            try
            {
                product.ProductStatus = productStatus;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        public Product[] GetAllProducts()
        {
            var allProducts = _productRepository.GetAllProducts();
            return allProducts;
        }
    }
}
