
namespace FactoryTracker.Models
{
    /// <summary>
    /// Комментарий
    /// </summary>
    public abstract class Comment
    {
        /// <summary>
        /// ID комментария
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// ID автора комментария
        /// </summary>
        public int AuthorUserID { get; set; }

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
            Text = text;
            DateTime = DateTime.UtcNow;
        }
    }
}
