using System.Web.Services.Protocols;

namespace SoapWebServiceDemo
{
    public class AuthSoapHeader : SoapHeader
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}