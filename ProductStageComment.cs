
namespace FactoryTracker
{
    internal class ProductStageComment : Comment
    {
        public uint ProductStageID { get; set; }
        public ProductStageComment(string text, uint productStageID) : base(text)
        {
            ProductStageID = productStageID;
        }
    }
}
