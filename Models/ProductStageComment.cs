namespace FactoryTracker.Models
{
    internal class ProductStageComment : Comment
    {
        /// <summary>
        /// ID этапа изделия
        /// </summary>
        public uint ProductStageID { get; set; }

        public ProductStageComment(string text, uint productStageID) : base(text)
        {
            ProductStageID = productStageID;
        }
    }
}
