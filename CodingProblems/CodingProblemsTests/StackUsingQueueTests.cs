using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;

namespace CodingProblemsTests
{
  [TestClass]
  public class StackUsingQueuesTests
  {
    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void QueueStack_PopEmptyStack_ExceptionThrown()
    {
      StackUsingQueue<String> stack = new StackUsingQueue<String>();
      stack.Pop();
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void QueueStack_PeekEmptyStack_ExceptionThrown()
    {
      StackUsingQueue<String> stack = new StackUsingQueue<String>();
      stack.Peek();
    }

    [TestMethod]
    public void QueueStack_PushAndPopElement_SameElementReturned()
    {
      StackUsingQueue<String> stack = new StackUsingQueue<String>();
      stack.Push("hi");
      String pop = stack.Pop();

      Assert.AreEqual(pop, "hi");
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void QueueStack_PushThenPopTwice_ExceptionThrown()
    {
      StackUsingQueue<String> stack = new StackUsingQueue<String>();
      stack.Push("hi");
      String pop = stack.Pop();
      stack.Pop();
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void QueueStack_PushThenPopThenPeak_ExceptionThrown()
    {
      StackUsingQueue<String> stack = new StackUsingQueue<String>();
      stack.Push("hi");
      String pop = stack.Pop();
      stack.Peek();
    }


    [TestMethod]
    public void QueueStack_PushMultipleAndPopMultiple_CorrectElementsReturned()
    {
      StackUsingQueue<String> stack = new StackUsingQueue<String>();
      stack.Push("hi");
      stack.Push("there");
      stack.Push("friend");

      String pop1 = stack.Pop();
      String pop2 = stack.Pop();
      String pop3 = stack.Pop();

      Assert.AreEqual("friend", pop1);
      Assert.AreEqual("there", pop2);
      Assert.AreEqual("hi", pop3);
    }

    [TestMethod]
    public void QueueStack_BuildUpStack_ThenThrash_CorrectElementsReturned()
    {
      StackUsingQueue<String> stack = new StackUsingQueue<String>();
      stack.Push("hi");
      stack.Push("there");
      stack.Push("friend");

      stack.Push("again");
      String pop1 = stack.Pop();
      stack.Push("what");
      String pop2 = stack.Pop();
      stack.Push("moo");
      String pop3 = stack.Pop();

      Assert.AreEqual("again", pop1);
      Assert.AreEqual("what", pop2);
      Assert.AreEqual("moo", pop3);
    }

    [TestMethod]
    public void QueueStack_EmptyStackIsEmpty_CorrectElementsReturned()
    {
      StackUsingQueue<String> stack = new StackUsingQueue<String>();
      bool isEmpty = stack.IsEmpty();

      Assert.AreEqual(true, isEmpty);
    }

    [TestMethod]
    public void QueueStack_StackNotEmptyAfterPush_CorrectElementsReturned()
    {
      StackUsingQueue<String> stack = new StackUsingQueue<String>();
      stack.Push("hi");
      bool isEmpty = stack.IsEmpty();

      Assert.AreEqual(false, isEmpty);
    }

    [TestMethod]
    public void QueueStack_StackEmptyAfterPushPop_CorrectElementsReturned()
    {
      StackUsingQueue<String> stack = new StackUsingQueue<String>();
      stack.Push("hi");
      stack.Pop();
      bool isEmpty = stack.IsEmpty();

      Assert.AreEqual(true, isEmpty);
    }
  }
}
