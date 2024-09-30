using FactoryTracker.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker.DAL.Repositories
{
    public class ProductStageRepository
    {
        private readonly Dictionary<int, ProductStage> _productStages;

        public ProductStageRepository()
        {
            _productStages = new Dictionary<int, ProductStage>();
        }

        private int IncrementProductStageId()
        {
            if (_productStages.Count == 0)
            {
                return 1;
            }
            else
            {
                return _productStages.MaxBy(k => k.Key).Key + 1;
            }
        }

        public void AddProductStage(ProductStage productStage)
        {
            int id = IncrementProductStageId();
            productStage.ID = id;
            _productStages.Add(id, productStage);
        }

        public ProductStage GetProductStage(int productStageId)
        {
            try
            {
                KeyValuePair<int, ProductStage> foundItem = _productStages.First(item => item.Key == productStageId);
                return foundItem.Value;
            }
            catch (Exception)
            {
                throw new Exception($"В словаре _productStages нет значения с ключом {productStageId}");
            }
        }
    }
}
