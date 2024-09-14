using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker.Models
{
    /// <summary>
    /// Комментарий
    /// </summary>
    public class Comment
    {
        public uint ID { get; set; }
        public uint AutorUserID { get; set; }

        /// <summary>
        /// Текст комментария
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Дата создания комментария
        /// </summary>
        public DateTime DateTime { get; set; }


        public Comment(string text)
        {
            // ?ID
            Text = text;
            DateTime = DateTime.Now;
        }
    }
}
