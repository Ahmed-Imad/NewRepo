using System;

namespace AppWarehouse.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal TotalCost { get; set; }
        public bool InStock { get; set; }
        public int BarCode { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
