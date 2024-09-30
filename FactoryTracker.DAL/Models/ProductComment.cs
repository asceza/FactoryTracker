namespace FactoryTracker.DAL.Models
{
    public class ProductComment : Comment
    {
        /// <summary>
        /// ID изделия
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// ID инициатора комментария
        /// </summary>
        public int? UserInitiatorID { get; set; }

        public ProductComment(string text, int productID, int userInitiatorID) : base(text)
        {
            ProductID = productID;
            UserInitiatorID = userInitiatorID;
        }
    }
}
