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
            /*
             * Из раза в раз повторяется одна и та же функциональность?
             * И при необходимости что-то поменять приходится менять во всех репозиториях.
             * В промышленных программах подобный подход чреват тем, что в момент очередного
             * массового изменения либо что-то скопируется и у класса Б будет функциональность
             * из метода класса А, либо просто класс Б будет пропущен.
             * Есть такой принцип - DRY (Don't Repeat Yourself, не повторяйся) и в соответствии
             * с ним предлагаю вынести общую функциональность в базовый класс, а то, что там разные
             * типы, решается с помощью дженериков. Если не получится сделать самому, то пиши и расскажу подробнее.
             */

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
