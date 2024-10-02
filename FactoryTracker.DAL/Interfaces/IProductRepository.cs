using FactoryTracker.DAL.Models;

namespace FactoryTracker.DAL.Interfaces
{
    public interface IProductRepository
    {
        // изменить result type
        bool AddProduct(Product product);
        Product GetProduct(string productNumber);
        public Product[] GetAllProducts();
    }
}