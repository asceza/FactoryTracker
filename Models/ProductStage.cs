using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker.Models
{
    /// <summary>
    /// "Этап производства (запись в БД)
    /// </summary>
    public class ProductStage
    {
        public uint ID { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
        public CraftOperation CraftOperation { get; set; }
        public ProductStatus ProductStatus { get; set; }
        public DateTime DateTime { get; set; }
        public uint ProductionDurationInHour { get; set; }

        /// <summary>
        /// Одиночный комментарий
        /// </summary>
        public Comment Comment { get; set; }

        public ProductStage(Product product,
                            User user,
                            CraftOperation craftOperation,
                            ProductStatus productStatus,
                            DateTime dateTime,
                            uint productionDurationInHour,
                            Comment comment)
        {
            Product = product;
            User = user;
            CraftOperation = craftOperation;
            ProductStatus = productStatus;
            DateTime = dateTime;
            ProductionDurationInHour = productionDurationInHour;
            Comment = comment;
        }

    }
}
