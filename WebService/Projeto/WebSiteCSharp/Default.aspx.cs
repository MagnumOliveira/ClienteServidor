using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
  }

  protected override void OnPreRender(EventArgs e)
  {
    base.OnPreRender(e);

    //Create an instance of the web service proxy class and call the web service method to get the
    //customer name. This proxy class is based upon the web reference added to the web site.
    localhost.CustomerServices wsCustomer = new localhost.CustomerServices();
    Label1.Text = wsCustomer.GetCustomerName(33);

  }
}
