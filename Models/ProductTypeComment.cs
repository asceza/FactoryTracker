namespace FactoryTracker.Models
{
    public class ProductTypeComment : Comment
    {
        /// <summary>
        /// ID типа изделия
        /// </summary>
        public uint ProductTypeID { get; set; }

        /// <summary>
        /// ID инициатора комментария
        /// </summary>
        public uint UserInitiatorID { get; set; }
        public ProductTypeComment(string text, uint productTypeID, uint userInitiatorID) : base(text)
        {
            ProductTypeID = productTypeID;
            UserInitiatorID = userInitiatorID;
        }
    }
}
