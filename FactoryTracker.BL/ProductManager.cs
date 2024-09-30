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
            _productRepository.AddProduct(product);
            
            // сделать проверка try
            return true;



        }


        public string[] GetAllProductNumbers()
        {
            var arr2 = _productRepository.GetAllProductNumbers();
            //var arr = arr2.Select.ToArray;
        }


    }
}
