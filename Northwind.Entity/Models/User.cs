using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Northwind.Entity.Base;

namespace Northwind.Entity.Models
{
    public class User:EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "User Id is required.")]
        public int UserId {get;set;}
        
        [MaxLength(30)]
        public string UserName {get;set;}
        
        [MaxLength(30)]
        public string UserLastName {get;set;}
        
        [MaxLength(40)]
        [Required(ErrorMessage = "User Code is required.")]
        public string UserCode {get;set;}
        
        [Required(ErrorMessage = "Password is required.")]
        [MaxLength(60)] 
        public string Password { get; set; }
    }
}