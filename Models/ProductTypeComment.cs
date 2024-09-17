namespace FactoryTracker.Models
{
    public class ProductTypeComment : Comment
    {

        /// <summary>
        /// ID инициатора комментария
        /// </summary>
        public uint? UserInitiatorID { get; set; }
        public ProductTypeComment(string text, uint userInitiatorID) : base(text)
        {
            UserInitiatorID = userInitiatorID;
        }
    }
}
