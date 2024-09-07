using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker
{
    /// <summary>
    /// Тип изделия
    /// </summary>
    public class ProductType
    {
        public uint ID { get; set; }
        public string Title { get; set; }
        public uint StandartDurationInHour { get; set; }
        public List <Comment> Comments { get; set; }



        public ProductType(uint id, string title, uint standartDurationInHour)
        {
            ID = id;
            Title = title;
            StandartDurationInHour = standartDurationInHour;
            Comments = new List<Comment>();
        }

        /// <summary>
        /// Добавление комментария к типу изделия
        /// </summary>
        /// <param name="text">Текст комментария</param>
        public void AddComment(string text)
        {
            if(!String.IsNullOrEmpty(text)) // проверка на пустую строку
                Comments.Add(new Comment(text));
            return;
        }
    }
}
