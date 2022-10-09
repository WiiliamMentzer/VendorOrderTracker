using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesOrder_Item()
    {
      Vendor newVendor = new Vendor("test", "the bakery");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnVendorName_String()
    {
      //Arrange
      string vendorName = "Test Vendor";
      Vendor newVendor = new Vendor(vendorName, "the bakery");

      //Act
      string result = newVendor.vendorName;

      //Assert
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void GetVendorDescription_ReturnVendorDescription_String()
    {
      //Arrange
      string vendorDescription = "the bakery";
      Vendor newVendor = new Vendor("BreadCity", vendorDescription);

      //Act
      string result = newVendor.vendorDescription;

      //Assert
      Assert.AreEqual(vendorDescription, result);
    }
    [TestMethod]
    public void SetNewDescription_SetDescription_String()
    {
      //Arrange
      string vendorDescription = "the bakery";
      Vendor newVendor = new Vendor("BreadCity", vendorDescription);

      //Act
      string newDescription = "The place of the bread";
      newVendor.vendorDescription = newDescription;
      string result = newVendor.vendorDescription;

      //Assert
      Assert.AreEqual(newDescription, result);
    }    


//Crippling Error (cannot put list in list)
    // [TestMethod]
    // public void GetAllVendorsOrders_ReturnVendorOrders_VendorOrdersList()
    // {
    //   //Arrange

    //   Order newOrder1 = new Order("Bread", "4/11/12", 200);
    //   Order newOrder2 = new Order("Cheese", "4/11/12", 100);
      
    //   Vendor newVendor = new Vendor("BreadCity", "The place of the bread");
    //   newVendor.AddOrder(newOrder1);
    //   newVendor.AddOrder(newOrder2);

    //   // List<Vendor> vendorList = new List<Vendor>();
    //   // vendorList.Add( new Vendor {
    //   //   Orders = new List<Order> { newOrder1, newOrder2 }
    //   // });
      
    //   //{ newOrder1, newOrder2 };

    //   //Act
    //   List<Vendor> result = newVendor.Orders;

    //   //Assert
    //   CollectionAssert.AreEqual(vendorList.Orders, result);

    // }
  }
}