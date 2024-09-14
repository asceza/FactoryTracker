namespace FactoryTracker.Models
{
    internal class ProductTypeComment : Comment
    {
        public uint ProductTypeID { get; set; }
        public ProductTypeComment(string text, uint productTypeID) : base(text)
        {
            ProductTypeID = productTypeID;
        }
    }
}
