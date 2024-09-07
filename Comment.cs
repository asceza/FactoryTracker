using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker
{
    /// <summary>
    /// Комментарий
    /// </summary>
    public class Comment
    {
        public uint ID { get; set; }

        /// <summary>
        /// Текст комментария
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Дата создания комментария
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// ID комментария
        /// </summary>
        private static uint commentID = 0;

        public Comment(string text)
        {
            commentID++;
            ID = commentID;
            Text = text;
            DateTime = DateTime.Now;
        }
    }
}
