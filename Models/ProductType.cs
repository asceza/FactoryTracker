using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker.Models
{
    /// <summary>
    /// Тип изделия
    /// </summary>
    public class ProductType
    {
        public uint ID { get; set; }
        public string Title { get; set; }
        public uint StandartDurationInHour { get; set; }
        public List<ProductTypeComment> ProductTypeComments { get; set; }

        public ProductType(uint id, string title, uint standartDurationInHour)
        {
            ID = id;
            Title = title;
            StandartDurationInHour = standartDurationInHour;
            ProductTypeComments = new List<ProductTypeComment>();
        }

        /// <summary>
        /// Добавление комментария к типу изделия
        /// </summary>
        /// <param name="text">Текст комментария</param>
        public void AddComment(string text, uint productTypeID, uint userInitiatorID)
        {
            if (!string.IsNullOrEmpty(text))
            {
                ProductTypeComments.Add(new ProductTypeComment(text, productTypeID, userInitiatorID));
            }
            return;
        }
    }
}
