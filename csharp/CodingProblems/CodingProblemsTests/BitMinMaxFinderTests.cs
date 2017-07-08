using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;

namespace CodingProblemsTests
{
  [TestClass]
  public class BitMinMaxFinderTests
  {
    [TestMethod]
    public void MinMax_PassIn2_ShouldReturn_1and4()
    {
      MinMaxResult result = BitMinMaxFinder.FindMinMaxBasedOnBitCount(2);
      Assert.AreEqual(4, result.max);
      Assert.AreEqual(1, result.min);
    }

    [TestMethod]
    public void MinMax_PassIn3_ShouldReturn_5andNeg1073741824()
    {
      MinMaxResult result = BitMinMaxFinder.FindMinMaxBasedOnBitCount(3);
      Assert.AreEqual(5, result.max);
      Assert.AreEqual(-1073741824, result.min);
    }

    [TestMethod]
    public void MinMax_PassInIntMax_ShouldReturn_IntMaxAndNegTwo()
    {
      MinMaxResult result = BitMinMaxFinder.FindMinMaxBasedOnBitCount(Int32.MaxValue);
      Assert.AreEqual(Int32.MaxValue, result.max);
      Assert.AreEqual(-2, result.min);
    }

    [TestMethod]
    public void MinMax_PassIn1073741824_ShouldReturn_SameAnd536870912()
    {
      MinMaxResult result = BitMinMaxFinder.FindMinMaxBasedOnBitCount(1073741824);
      Assert.AreEqual(1073741824, result.max);
      Assert.AreEqual(536870912, result.min);
    }

    [TestMethod]
    public void MinMaxPassIn4_ShouldReturn_8and2()
    {
      MinMaxResult result = BitMinMaxFinder.FindMinMaxBasedOnBitCount(4);
      Assert.AreEqual(8, result.max);
      Assert.AreEqual(2, result.min);
    }
  }
}
