﻿namespace FactoryTracker.Models
{
    internal class ProductComment : Comment
    {
        /// <summary>
        /// ID изделия
        /// </summary>
        public uint ProductID { get; set; }

        /// <summary>
        /// ID инициатора комментария
        /// </summary>
        public uint UserInitiatorID { get; set; }

        public ProductComment(string text, uint productID, uint userInitiatorID) : base(text)
        {
            ProductID = productID;
            UserInitiatorID = userInitiatorID;
        }
    }
}
