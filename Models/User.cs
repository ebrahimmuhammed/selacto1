
using System.ComponentModel.DataAnnotations;
namespace MESS.Models
{

    public class User
    {
        [Key]
        public  int productId { get; set; }
        [Required]

        public string productName {get;set;} 
        public string productCategory {get;set;} 
    }
}