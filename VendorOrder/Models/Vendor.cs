using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    public static List<Vendor> _instances = new List<Vendor> {};
    public string vendorName { get; set; }
    public string vendorDescription { get; set; }
    public int ID { get; }
    public List<Order> Order { get; set; }

    public Vendor(string name, string description)
    {
      vendorName = name;
      vendorDescription = description
      _instances.Add(this);
      ID = _instances.Count;
      Order = new List<Order>{};
    }

    public static List<Order> GetAllVendors()
    {
      return _instances;
    }

    public static Vendor Find(int vendorID)
    {
      return _instances[vendorID-1];
    }
  }
}