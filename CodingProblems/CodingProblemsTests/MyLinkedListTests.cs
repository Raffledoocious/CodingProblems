using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;

namespace CodingProblemsTests
{
  [TestClass]
  public class MyLinkedListTests
  {
    [TestMethod]
    public void LinkedList_TwoElements_RemovingFirstSucceeds()
    {
      MyLinkedList list = new MyLinkedList();
      list.Append("hi");
      list.Append("there");

      list.RemoveElement("hi");

      string[] resultList = list.GetElements();

      Assert.AreEqual("there", resultList[0]);
    }

    [TestMethod]
    public void LinkedList_ThreeElements_RemovingFirstTwoSucceeds()
    {
      MyLinkedList list = new MyLinkedList();
      list.Append("hi");
      list.Append("there");
      list.Append("sir");

      list.RemoveElement("hi");
      list.RemoveElement("there");

      string[] resultList = list.GetElements();

      Assert.AreEqual("sir", resultList[0]);
    }

    [TestMethod]
    public void LinkedList_FiveElements_RemoveMiddleThree_ExpectFirstAndLastReturned()
    {
      MyLinkedList list = new MyLinkedList();
      list.Append("hi");
      list.Append("there");
      list.Append("sir");
      list.Append("how");
      list.Append("are");

      list.RemoveElement("how");
      list.RemoveElement("there");
      list.RemoveElement("sir");


      string[] resultList = list.GetElements();

      Assert.AreEqual("hi", resultList[0]);
      Assert.AreEqual("are", resultList[1]);
    }

    [TestMethod]
    public void LinkedList_FiveElements_Remove1and4_ExpectCorrectThree()
    {
      MyLinkedList list = new MyLinkedList();
      list.Append("hi");
      list.Append("there");
      list.Append("sir");
      list.Append("how");
      list.Append("are");

      list.RemoveElement("hi");
      list.RemoveElement("how");


      string[] resultList = list.GetElements();

      Assert.AreEqual("there", resultList[0]);
      Assert.AreEqual("sir", resultList[1]);
      Assert.AreEqual("are", resultList[2]);
    }

    [TestMethod]
    public void LinkedList_FiveElements_RemoveLast_DoesNotModifyList()
    {
      MyLinkedList list = new MyLinkedList();
      list.Append("hi");
      list.Append("there");
      list.Append("sir");
      list.Append("how");
      list.Append("are");

      list.RemoveElement("are");
      string[] resultList = list.GetElements();

      Assert.AreEqual("hi", resultList[0]);
      Assert.AreEqual("there", resultList[1]);
      Assert.AreEqual("sir", resultList[2]);
      Assert.AreEqual("how", resultList[3]);
      Assert.AreEqual("are", resultList[4]);
    }
  }
}
