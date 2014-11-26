using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

//Links on WSDL FYI
//http://www.w3.org/TR/wsdl
//http://www.w3schools.com/wsdl/default.asp

namespace WebServiceCSharp
{
  /// <summary>
  /// Web service class Service1 with attributes describing the service and its binding.
  /// </summary>
  [WebService(Namespace = "http://howdoi.org/", Description = "This is a sample service for How Do I videos.", Name = "MyService")]
  [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
  [ToolboxItem(false)]
  public class Service1 : System.Web.Services.WebService
  {

    /// <summary>
    /// Simple web method w/o parameters that returns a string.
    /// </summary>
    [WebMethod]
    public string HelloWorld()
    {
      return "Hello World";
    }
  }
}
