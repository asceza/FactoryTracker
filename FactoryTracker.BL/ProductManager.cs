using FactoryTracker.DAL.Interfaces;
using FactoryTracker.DAL.Models;
using FactoryTracker.DAL.Repositories;
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

        public Product GetProductByNumber(string selectedProductNumber)
        {
            var allProducts = _productRepository.GetAllProducts();
            Product product = allProducts.First(p => p.Number == selectedProductNumber);
            return product;
        }
    }
}
