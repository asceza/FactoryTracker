
namespace FactoryTracker.Models
{
    /// <summary>
    /// Комментарий
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// ID комментария
        /// </summary>
        public uint ID { get; set; }

        /// <summary>
        /// ID автора комментария
        /// </summary>
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
