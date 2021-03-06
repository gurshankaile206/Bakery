using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreBakery.Models;
using System;

namespace PierreBakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder= new Order("test", "test", "test", "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsProperties_String()
    {
      //Arrange
      string description = "a lot of order";
      string title = "15 cupcakes";
      string price = "12 dollars";
      string date = "06-15-2021";

      //Act
      Order newOrder = new Order(description, title, price, date );
      string result = newOrder.Description;
      string result2 = newOrder.Title;
      string result3 = newOrder.Price;
      string result4 = newOrder.Date;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "a lot of orders.";
      string title = "15 cupcakes";
      string price = "12 dollars";
      string date = "06-15-2021";
      Order newOrder = new Order(description, title, price, date);

      //Act
      string updatedDescription = "need order asap";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newOrder = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newOrder, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_Orderist()
    {
      //Arrange
      string description01 = "a lot of orders";
      string description02 = "too many orders";
      string title01 = "15 cupcakes";
      string title02 = "30 cupcakes";
      string price01 = "12 dollars";
      string price02 = "30 dollars";
      string date01= "06-15-2021";
      string date02 = "09-12-2020";
      Order newOrder1 = new Order(description01, title01, price01, date01);
      Order newOrder2 = new Order(description02, title02, price02, date02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}