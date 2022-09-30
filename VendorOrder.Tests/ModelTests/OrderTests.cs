using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesOrder_Item()
    {
      Order newOrder = new Order("Bread", "4/11/12", 200);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderDescription_ReturnOrderDescription_String()
    {
      //Arrange
      string orderDescription = "Bread";
      Order newOrder = new Order(orderDescription, "4/11/12", 200);

      //Act
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(orderDescription, result);
    }

    [TestMethod]
    public void GetOrderDate_ReturnOrderDate_String()
    {
      //Arrange
      string orderDate = "4/11/12";
      Order newOrder = new Order("Bread", orderDate, 200);

      //Act
      string result = newOrder.Date;

      //Assert
      Assert.AreEqual(orderDate, result);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnOrderPrice_Int()
    {
      //Arrange
      int orderPrice = 200;
      Order newOrder = new Order("Bread", "4/11/12", orderPrice);

      //Act
      int result = newOrder.Price;

      //Assert
      Assert.AreEqual(orderPrice, result);
    }



  }
}