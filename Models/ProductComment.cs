namespace FactoryTracker.Models
{
    internal class ProductComment : Comment
    {
        public uint ProductID { get; set; }
        public ProductComment(string text, uint productID) : base(text)
        {
            ProductID = productID;
        }
    }
}
