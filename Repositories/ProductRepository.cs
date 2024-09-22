using FactoryTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker.Repositories
{
    public class ProductRepository
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

        public void AddProduct(Product product)
        {
            int id = IncrementProductId();
            product.ID = id;
            _products.Add(id, product);
        }

        public Product GetProduct(int productId)
        {
            try
            {
                KeyValuePair<int, Product> foundItem = _products.First(item => item.Key == productId);
                return foundItem.Value;
            }
            catch (Exception)
            {
                throw new Exception($"В словаре _products нет значения с ключом {productId}");
            }
        }
    }
}
