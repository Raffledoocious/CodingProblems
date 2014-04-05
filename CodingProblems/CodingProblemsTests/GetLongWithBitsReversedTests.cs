using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;

namespace CodingProblemsTests
{
  [TestClass]
  public class GetLongWithBitsReversedTests
  {
    [TestMethod]
    public void ReversingBits_SingleBit_ReturnsSameNumber()
    {
      ulong value = 1;
      ulong reversedValue = BitReversal.GetLongWithBitsReversed(value, 1);

      Assert.AreEqual(value, reversedValue);
    }
  }
}
