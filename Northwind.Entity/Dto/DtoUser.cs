using System.Text.Json.Serialization;
using Northwind.Entity.Base;

namespace Northwind.Entity.Dto
{
    public class DtoUser:DtoBase
    {
        public int UserId {get;set;}
        public string UserName {get;set;}
        public string UserLastName {get;set;}
        public string UserCode {get;set;} 
        [JsonIgnore]
        public string Password { get; set; }
    }
}