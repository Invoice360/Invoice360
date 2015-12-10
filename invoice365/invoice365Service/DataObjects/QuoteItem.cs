﻿using Microsoft.WindowsAzure.Mobile.Service;

namespace invoice365Service.DataObjects
{

    public class QuoteItem : EntityData
    {
        public string UserId { get; set; }
        public string MasterItemId { get; set; }
        public string QuoteNumber { get; set; }
        public string QuoteId { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public bool Taxable { get; set; }

        //public long MasterDocumentVersion { get; set; }

    }
}