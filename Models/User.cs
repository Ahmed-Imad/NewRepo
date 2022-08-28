using System.ComponentModel.DataAnnotations;

namespace AppWareHouse.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Please enter user name")]
        public string UserName { get; set; }
        [DataType (DataType.Password)]
        public string Password { get; set; }
    }
}
