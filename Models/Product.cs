using System;
using System.ComponentModel.DataAnnotations;

namespace AppWareHouse.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required (ErrorMessage = "Please Enter Product Name")]
        [Display (Name = "Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please enter price")]
        public decimal? Price { get; set; }
        
        [Required(ErrorMessage = "Please enter Qty")]
        public int? Qty { get; set; }
        public decimal TotalCost { get; set; }
        public bool InStock { get; set; }
        
        [Required(ErrorMessage = "Please enter barCode")]
        public int? BarCode { get; set; }
        [Required(ErrorMessage = "Please enter date")]
        public DateTime? CreationDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
