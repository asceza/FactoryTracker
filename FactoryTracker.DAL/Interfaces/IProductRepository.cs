using FactoryTracker.Core;
using FactoryTracker.DAL.Models;

namespace FactoryTracker.DAL.Interfaces
{
    public interface IProductRepository
    {
        // изменить на result type
        public Result<bool> AddProduct(Product product);
        public Result<Product> GetProduct(string productNumber);
        public Product[] GetAllProducts();
    }
}