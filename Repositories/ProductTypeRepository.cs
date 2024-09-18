using FactoryTracker.Models;


namespace FactoryTracker.Repositories
{
    public class ProductTypeRepository
    {
        private readonly Dictionary<int, ProductType> _productTypes;

        public ProductTypeRepository()
        {
            _productTypes = new Dictionary<int, ProductType>();
        }

        private int IncrementProductTypeId()
        {
            if (_productTypes.Count == 0)
            {
                return 1;
            }
            else
            {
                return _productTypes.MaxBy(k => k.Key).Key + 1;
            }
        }

        public void AddProductType(ProductType productType)
        {
            int id = IncrementProductTypeId();
            productType.ID = id;
            _productTypes.Add(id, productType);
        }

        public ProductType GetProductType(int productTypeId)
        {
            KeyValuePair<int, ProductType> foundItem = _productTypes.FirstOrDefault(item => item.Key == productTypeId);
            return foundItem.Value;
        }
    }
}
