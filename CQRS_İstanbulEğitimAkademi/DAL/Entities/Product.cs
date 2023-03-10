using System;

namespace CQRS_İstanbulEğitimAkademi.DAL.Entities
{
    public class Product
    {
        public int ProductID { get; set; }  
        public string ProductName { get; set; }
        public int? Stock { get; set; }

        public string Description { get; set; }
        public string Storage { get; set; }
        public string Shelf { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? SalePrice { get; set; }
        public int? Tax { get; set; }
        public string Image { get; set; }
        public string SizeType { get; set; }
        public decimal? Size { get; set; }
        public bool Status { get; set; }

    }
}
