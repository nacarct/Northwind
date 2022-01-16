using System.ComponentModel.DataAnnotations;

namespace Northwind.Entity.Dto
{
    public class DtoLogin
    {
        [Required] public string UserCode { get; set; }
        
        [Required] public string Password { get; set; }
    }
}