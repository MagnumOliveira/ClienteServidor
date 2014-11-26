using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerCSharp
{
  /// <summary>
  /// Sample complex object class that is passed in/out of a web method in WebServiceVB.
  /// </summary>
  public class Customer
  {

    /// <summary>
    /// Sample property, full object would represent all customer data with additional properties.
    /// </summary>
    private String customerName;
    public String CustomerName
    {
      get { return customerName; }
      set { customerName = value; }
    }

  }
}
