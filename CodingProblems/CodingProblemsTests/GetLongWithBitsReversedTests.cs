using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;

namespace CodingProblemsTests
{
  [TestClass]
  public class GetLongWithBitsReversedTests
  {
    [TestMethod]
    public void ReverseBits_5bits_27_Returns27()
    {
      //using 11011
      ulong value = 27;
      ulong reversedValue = BitReversal.GetLongWithBitsReversed(value, 5);

      Assert.AreEqual(value, reversedValue);
    }

    [TestMethod]
    public void ReverseBits_5bits_1_Returns16()
    {
      ///using 00001 which should return 16
      ulong value = 1;
      ulong reversedValue = BitReversal.GetLongWithBitsReversed(value, 5);

      Assert.AreEqual(Convert.ToUInt64(16), reversedValue);
    }

    [TestMethod]
    public void ReverseBits_5bits_24_Returns3()
    {
      ///using 11000 which should return 16
      ulong value = 24;
      ulong reversedValue = BitReversal.GetLongWithBitsReversed(value, 5);

      Assert.AreEqual(Convert.ToUInt64(3), reversedValue);
    }

    [TestMethod]
    public void ReverseBits_64bits_IntMax_ReturnsIntMax()
    {
      ///int max should return int max
      ulong value = UInt64.MaxValue;
      ulong reversedValue = BitReversal.GetLongWithBitsReversed(value, 64);

      Assert.AreEqual(value, reversedValue);
    }

    [TestMethod]
    public void ReverseBits_64bits_1125883080014581_Returns394903367593229824()
    {
      ///int max should return int max
      ulong value = UInt64.MaxValue;
      ulong reversedValue = BitReversal.GetLongWithBitsReversed(value, 64);

      Assert.AreEqual(value, reversedValue);
    }
  }
}
