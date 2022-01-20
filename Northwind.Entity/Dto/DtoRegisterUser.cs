using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Northwind.Entity.Base;

namespace Northwind.Entity.Dto
{
    public class DtoRegisterUser:DtoBase
    {
        [JsonIgnore]
        public int UserId {get;set;}
        [Required(ErrorMessage = "User Name is required!")]
        public string UserName {get;set;}
        [Required(ErrorMessage = "User Last Name is required!")]
        public string UserLastName {get;set;}
        [Required(ErrorMessage = "User Code is required!")]
        public string UserCode {get;set;} 
        [Required(ErrorMessage = "Password is required!")]
        public string Password { get; set; }
    }
}