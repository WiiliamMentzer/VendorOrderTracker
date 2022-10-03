using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Description { get; set; }
    public string Date { get; set; }
    public int Price { get; set; }
    public int ID { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string description, string date, int price)
    {
      Description = description;
      Date = date;
      Price = price;
      _instances.Add(this);
      ID = _instances.Count;
    }

    public static List<Order> GetAllOrders()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }


    public static Order FindOrder(int orderID)
    {
      return _instances[orderID-1];
    }
  }
}