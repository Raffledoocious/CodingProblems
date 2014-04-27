using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;

namespace CodingProblemsTests
{
  [TestClass]
  public class MaxQueueTests
  {
    [TestMethod]
    public void MaxQueue_IncreasingElements_LastElementIsLargest()
    {
      MaxQueue<int> queue = new MaxQueue<int>();
      queue.Enque(1);
      queue.Enque(2);
      queue.Enque(3);
      queue.Enque(4);

      int max = queue.GetMax();
      Assert.AreEqual(4, max);
    }

    [TestMethod]
    public void MaxQueue_AllEqualElementsButOne_MaxElementReturned()
    {
      MaxQueue<int> queue = new MaxQueue<int>();
      queue.Enque(4);
      queue.Enque(1);
      queue.Enque(1);
      queue.Enque(1);

      int max = queue.GetMax();
      Assert.AreEqual(4, max);      
    }

    [TestMethod]
    public void MaxQueue_DequeueMax_MaxUpdatesCorrectly()
    {
      MaxQueue<int> queue = new MaxQueue<int>();
      queue.Enque(6);
      queue.Enque(4);
      queue.Enque(4);
      queue.Enque(5);

      int max = queue.GetMax();
      Assert.AreEqual(6, max);

      queue.Dequeue();
      max = queue.GetMax();
      Assert.AreEqual(5, max);

      queue.Dequeue();
      max = queue.GetMax();
      Assert.AreEqual(5, max);
    }
  }
}
