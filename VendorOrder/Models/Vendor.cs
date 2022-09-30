using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    public static List<Vendor> _instances = new List<Vendor> {};
    public string vendorName { get; set; }
    public string vendorDescription { get; set; }
    public int ID { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string name, string description)
    {
      vendorName = name;
      vendorDescription = description;
      _instances.Add(this);
      ID = _instances.Count;
      Orders = new List<Order>{};
    }

    public static List<Vendor> GetAllVendors()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int vendorID)
    {
      return _instances[vendorID-1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}