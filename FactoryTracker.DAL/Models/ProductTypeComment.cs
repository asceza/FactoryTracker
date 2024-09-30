namespace FactoryTracker.DAL.Models
{
    public class ProductTypeComment : Comment
    {

        /// <summary>
        /// ID инициатора комментария
        /// </summary>
        public int? UserInitiatorID { get; set; }
        public ProductTypeComment(string text, int userInitiatorID) : base(text)
        {
            UserInitiatorID = userInitiatorID;
        }
    }
}
