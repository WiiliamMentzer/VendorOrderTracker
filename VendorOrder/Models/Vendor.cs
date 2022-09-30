using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    public static List<Vendor> _instances = new List<Vendor> {};
    public string VendorName { get; set; }
    public int ID { get; }
    public List<Order> Order { get; set; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      ID = _instances.Count;
      Order = new List<Order>{};
    }
  }
}