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

  }
}