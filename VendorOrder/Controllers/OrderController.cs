using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;

namespace VendorOrder.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{vendorId}/items/new")]
    public ActionResult New(int orderId)
    {
      Order order = Order.FindOrder(orderId);
      return View(order);
    }

    [HttpGet("/categories/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.FindOrder(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("Order", order);
      model.Add("Vendor", vendor);
      return View(model);
    }
  }
}