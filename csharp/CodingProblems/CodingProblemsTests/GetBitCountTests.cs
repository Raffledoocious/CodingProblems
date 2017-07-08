using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;

namespace CodingProblemsTests
{
  [TestClass]
  public class GetBitCountTests
  {
    [TestMethod]
    public void GetBitCount_2_ShouldReturn1()
    {
      int bitCount = GetBitCount.GetBitCountFromInt(2);
      Assert.AreEqual(1, bitCount);
    }

    [TestMethod]
    public void GetBitCount_Neg2_ShouldReturn2()
    {
      int bitCount = GetBitCount.GetBitCountFromInt(-2);
      Assert.AreEqual(2, bitCount);
    }

    [TestMethod]
    public void GetBitCount_3_ShouldReturn2()
    {
      int bitCount = GetBitCount.GetBitCountFromInt(3);
      Assert.AreEqual(2, bitCount);
    }

    [TestMethod]
    public void GetBitCount_Neg3_ShouldReturn3()
    {
      int bitCount = GetBitCount.GetBitCountFromInt(-3);
      Assert.AreEqual(3, bitCount);
    }

    [TestMethod]
    public void GetBitCount_0_ShouldReturn0()
    {
      int bitCount = GetBitCount.GetBitCountFromInt(0);
      Assert.AreEqual(0, bitCount);
    }

    [TestMethod]
    public void GetBitCount_IntMax_ShouldReturn31()
    {
      int bitCount = GetBitCount.GetBitCountFromInt(Int32.MaxValue);
      Assert.AreEqual(31, bitCount);
    }

    [TestMethod]
    public void GetBitCount_IntMin_ShouldReturn32()
    {
      int bitCount = GetBitCount.GetBitCountFromInt(Int32.MinValue);
      Assert.AreEqual(32, bitCount);
    }

    [TestMethod]
    public void GetBitCount_21_ShouldReturn3()
    {
      int bitCount = GetBitCount.GetBitCountFromInt(21);
      Assert.AreEqual(3, bitCount);
    }

    [TestMethod]
    public void GetBitCount_Neg21_ShouldReturn4()
    {
      int bitCount = GetBitCount.GetBitCountFromInt(-21);
      Assert.AreEqual(4, bitCount);
    }
  }
}
