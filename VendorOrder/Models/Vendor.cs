using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    public static List<Vendor> _instances = new List<Vendor> {};
    public string vendorName { get; set; }
    public int ID { get; }
    public List<Order> Order { get; set; }

    public Vendor(string name)
    {
      vendorName = name;
      _instances.Add(this);
      ID = _instances.Count;
      Order = new List<Order>{};
    }
  }
}