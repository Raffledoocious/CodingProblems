using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;
using System.Collections.Generic;

namespace CodingProblemsTests
{
  [TestClass]
  public class MyLinkedListTests
  {
    [TestMethod]
    public void Remove_TwoElements_RemovingFirstSucceeds()
    {
      MyLinkedList<string> list = new MyLinkedList<string>();
      list.Append("hi");
      list.Append("there");

      list.RemoveElement("hi");

      string[] resultList = list.GetElements();

      Assert.AreEqual("there", resultList[0]);
    }

    [TestMethod]
    public void Remove_ThreeElements_RemovingFirstTwoSucceeds()
    {
      MyLinkedList<string> list = new MyLinkedList<string>();
      list.Append("hi");
      list.Append("there");
      list.Append("sir");

      list.RemoveElement("hi");
      list.RemoveElement("there");

      string[] resultList = list.GetElements();

      Assert.AreEqual("sir", resultList[0]);
    }

    [TestMethod]
    public void Remove_FiveElements_RemoveMiddleThree_ExpectFirstAndLastReturned()
    {
      MyLinkedList<string> list = new MyLinkedList<string>();
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
    public void Remove_FiveElements_Remove1and4_ExpectCorrectThree()
    {
      MyLinkedList<string> list = new MyLinkedList<string>();
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
    public void Remove_FiveElements_RemoveLast_DoesNotModifyList()
    {
      MyLinkedList<string> list = new MyLinkedList<string>();
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

    /*
     * Tests around removing the kth element
     */

    [TestMethod]
    public void kThRemoval_FiveElements_4thElementFromEnd_ShouldRemoveFirstElement()
    {
      MyLinkedList<string> list = new MyLinkedList<string>();
      list.Append("hi");
      list.Append("there");
      list.Append("sir");
      list.Append("how");
      list.Append("are");

      list.RemoveKthElementFromEnd(4);
      string[] resultList = list.GetElements();

      Assert.AreEqual("there", resultList[0]);
      Assert.AreEqual("sir", resultList[1]);
      Assert.AreEqual("how", resultList[2]);
      Assert.AreEqual("are", resultList[3]);
    }

    [TestMethod]
    public void kThRemoval_FiveElements_1stElementFromEnd_ShouldRemove2ndToLastElement()
    {
      MyLinkedList<string> list = new MyLinkedList<string>();
      list.Append("hi");
      list.Append("there");
      list.Append("sir");
      list.Append("how");
      list.Append("are");

      list.RemoveKthElementFromEnd(1);
      string[] resultList = list.GetElements();

      Assert.AreEqual("hi", resultList[0]);
      Assert.AreEqual("there", resultList[1]);
      Assert.AreEqual("sir", resultList[2]);
      Assert.AreEqual("are", resultList[3]);
    }

    [TestMethod]
    public void kThRemoval_FiveElements_RemoveMiddleElement_ShouldRemoveCorrectElement()
    {
      MyLinkedList<string> list = new MyLinkedList<string>();
      list.Append("hi");
      list.Append("there");
      list.Append("sir");
      list.Append("how");
      list.Append("are");

      list.RemoveKthElementFromEnd(2);
      string[] resultList = list.GetElements();

      Assert.AreEqual("hi", resultList[0]);
      Assert.AreEqual("there", resultList[1]);
      Assert.AreEqual("how", resultList[2]);
      Assert.AreEqual("are", resultList[3]);
    }

    [TestMethod]
    public void kThRemoval_FiveElements_RemoveMiddleElements_ShouldRemoveCorrectElement()
    {
      MyLinkedList<string> list = new MyLinkedList<string>();
      list.Append("hi");
      list.Append("there");
      list.Append("sir");
      list.Append("how");
      list.Append("are");

      list.RemoveKthElementFromEnd(2);
      list.RemoveKthElementFromEnd(2);
      string[] resultList = list.GetElements();

      Assert.AreEqual("hi", resultList[0]);
      Assert.AreEqual("how", resultList[1]);
      Assert.AreEqual("are", resultList[2]);
    }

    [TestMethod]
    public void JumpOrder_ThreeElements_JumpOrderIsCorrect()
    {
      MyLinkedList<string> list = new MyLinkedList<string>();
      list.Append("hi");
      list.Append("there");
      list.Append("friend");

      list.SetJumpNode(0, 2);
      list.SetJumpNode(2, 1);
      list.SetJumpNode(1, 2);

      list.ComputeJumpOrder();

      MyLinkedListNode<string>[] nodes = list.GetNodeElements();
      List<int> expectedOrder = new List<int>() { 1, 3, 2 };
      VerifyJumpOrders(expectedOrder, nodes);
    }

    [TestMethod]
    public void JumpOrder_FiveElements_PointingInOrder_OrderIsCorrect()
    {
      MyLinkedList<string> list = new MyLinkedList<string>();
      list.Append("hi");
      list.Append("there");
      list.Append("friend");
      list.Append("and");
      list.Append("gents");

      list.SetJumpNode(0, 1);
      list.SetJumpNode(1, 2);
      list.SetJumpNode(2, 3);
      list.SetJumpNode(3, 4);
      list.SetJumpNode(4, 0);

      list.ComputeJumpOrder();

      MyLinkedListNode<string>[] nodes = list.GetNodeElements();
      List<int> expectedOrder = new List<int>() { 1, 2, 3, 4, 5 };
      VerifyJumpOrders(expectedOrder, nodes);
    }

    [TestMethod]
    public void JumpOrder_FiveElements_CircularLoop_OrderIsCorrect()
    {
      MyLinkedList<string> list = new MyLinkedList<string>();
      list.Append("hi");
      list.Append("there");
      list.Append("friend");
      list.Append("and");
      list.Append("gents");

      list.SetJumpNode(0, 4);
      list.SetJumpNode(4, 1);
      list.SetJumpNode(3, 1);
      list.SetJumpNode(2, 3);
      list.SetJumpNode(1, 4);

      list.ComputeJumpOrder();

      MyLinkedListNode<string>[] nodes = list.GetNodeElements();
      List<int> expectedOrder = new List<int>() { 1, 3, 4, 5, 2 };
      VerifyJumpOrders(expectedOrder, nodes);
    }
    
    [TestMethod]
    public void JumpOrder_FiveElements_AllPointingToSameNode_OrderIsCorrect()
    {
      MyLinkedList<string> list = new MyLinkedList<string>();
      list.Append("hi");
      list.Append("there");
      list.Append("friend");
      list.Append("and");
      list.Append("gents");

      list.SetJumpNode(0, 0);
      list.SetJumpNode(1, 0);
      list.SetJumpNode(2, 0);
      list.SetJumpNode(3, 0);
      list.SetJumpNode(4, 0);

      list.ComputeJumpOrder();

      MyLinkedListNode<string>[] nodes = list.GetNodeElements();
      List<int> expectedOrder = new List<int>() { 1, 2, 3, 4, 5 };
      VerifyJumpOrders(expectedOrder, nodes);
    }

    [TestMethod]
    public void JumpOrder_FiveElements_MixOfPointers_OrderIsCorrect()
    {
      MyLinkedList<string> list = new MyLinkedList<string>();
      list.Append("hi");
      list.Append("there");
      list.Append("friend");
      list.Append("and");
      list.Append("gents");

      list.SetJumpNode(0, 3);
      list.SetJumpNode(1, 0);
      list.SetJumpNode(2, 1);
      list.SetJumpNode(3, 1);
      list.SetJumpNode(4, 3);

      list.ComputeJumpOrder();

      MyLinkedListNode<string>[] nodes = list.GetNodeElements();
      List<int> expectedOrder = new List<int>() { 1, 3, 4, 2, 5 };
      VerifyJumpOrders(expectedOrder, nodes);
    }

    private void VerifyJumpOrders(List<int> expectedOrders, MyLinkedListNode<string>[] nodes)
    {
      for (int i = 0; i < nodes.Length; i++)
      {
        Assert.AreEqual(nodes[i].JumpOrder, expectedOrders[i]);
      }
    }
  }
}
