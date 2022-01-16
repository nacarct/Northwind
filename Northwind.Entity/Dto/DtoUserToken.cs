using Northwind.Entity.IBase;

namespace Northwind.Entity.Dto
{
    public class DtoUserToken:IDtoBase
    {
        public DtoLoginUser DtoLoginUser { get; set; }
        public string AccessToken { get; set; }
    }
}