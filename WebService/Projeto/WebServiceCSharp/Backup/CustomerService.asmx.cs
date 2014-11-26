using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebServiceCSharp
{
  /// <summary>
  /// Sample web service providing methods w/ various parameters and return values/objects.
  /// </summary>
  [WebService(Name = "CustomerServices.", Namespace = "http://howdoi.org/")]
  [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
  [ToolboxItem(false)]
  public class CustomerService : System.Web.Services.WebService
  {

    /// <summary>
    /// Sample method w/ a parameter and a return value.
    /// </summary>
    [WebMethod]
    public String GetCustomerName(int id)
    {

      //'Get customer name from the database.
      return "Microsoft Corporation";

    }

    /// <summary>
    /// Sample method w/ a parameter and a return value.
    /// </summary>
    [WebMethod]
    public bool InsertCustomer(String cust)
    {
      //'Call data access class to insert the new customer.
      return true;
    }

    /// <summary>
    /// Sample method w/ a parameter that returns a complex object, our business object representing a customer.
    /// </summary>
    [WebMethod]
    public CustomerCSharp.Customer GetCustomer(int custID)
    {
      CustomerCSharp.Customer cust = new CustomerCSharp.Customer();
      cust.CustomerName = "Sun Microsystems";
      return cust;
    }

  }
}
