using Northwind.Entity.Base;

namespace Northwind.Entity.Dto
{
    public class DtoLoginUser:DtoBase
    {
        public int UserId {get;set;}
        public string UserName {get;set;}
        public string UserLastName {get;set;}
        public string UserCode {get;set;} 
    }
}