using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;

namespace CodingProblemsTests
{
  [TestClass]
  public class MaxSumOfTwoPairsTests
  {
    [TestMethod]
    public void SecondMaxSum_WithOneInteger_ReturnsInteger()
    {
      int[] array = new int[1] { 10 };
      int result = MaxSumOfTwoPairs.FindSecondLargestMaxOfTwoPairs(array);

      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void SecondMaxSum_WithTwoIntegers_ReturnsSum()
    {
      int[] array = new int[2] { 10, 2 };
      int result = MaxSumOfTwoPairs.FindSecondLargestMaxOfTwoPairs(array);

      Assert.AreEqual(12, result);
    }

    [TestMethod]
    public void SecondMaxSum_WithThreeIntegers_SortedAsc_ReturnsCorrectSum()
    {
      int[] array = new int[3] { 1, 2, 10};
      int result = MaxSumOfTwoPairs.FindSecondLargestMaxOfTwoPairs(array);

      Assert.AreEqual(11, result);
    }

    [TestMethod]
    public void SecondMaxSum_WithThreeIntegers_SortedDesc_ReturnsCorrectSum()
    {
      int[] array = new int[3] { 10, 2, 1 };
      int result = MaxSumOfTwoPairs.FindSecondLargestMaxOfTwoPairs(array);

      Assert.AreEqual(11, result);
    }

    [TestMethod]
    public void SecondMaxSum_WithThreeIntegers_LargestInMiddle_ReturnsCorrectSum()
    {
      int[] array = new int[3] { 1, 20, 10 };
      int result = MaxSumOfTwoPairs.FindSecondLargestMaxOfTwoPairs(array);

      Assert.AreEqual(21, result);
    }

    [TestMethod]
    public void SecondMaxSum_WithFiveIntegers_AllSame_ReturnsCorrectSum()
    {
      int[] array = new int[5] { 10, 10, 10, 10, 10 };
      int result = MaxSumOfTwoPairs.FindSecondLargestMaxOfTwoPairs(array);

      Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void SecondMaxSum_WithFiveIntegers_OneDifferent_ReturnsCorrectSum()
    {
      int[] array = new int[5] { 10, 10, 10, 1, 10 };
      int result = MaxSumOfTwoPairs.FindSecondLargestMaxOfTwoPairs(array);

      Assert.AreEqual(11, result);
    }

    [TestMethod]
    public void SecondMaxSum_WithFiveIntegers_AllDifferent_ReturnsCorrectSum()
    {
      int[] array = new int[5] { 122, 123, 11, 1, 12 };
      int result = MaxSumOfTwoPairs.FindSecondLargestMaxOfTwoPairs(array);

      Assert.AreEqual(135, result);
    }

    [TestMethod]
    public void SecondMaxSum_WithFiveIntegers_SortAsc_ReturnsCorrectSum()
    {
      int[] array = new int[5] { 1, 2, 3, 4, 5 };
      int result = MaxSumOfTwoPairs.FindSecondLargestMaxOfTwoPairs(array);

      Assert.AreEqual(8, result);
    }

    [TestMethod]
    public void SecondMaxSum_WithFiveIntegers_SortDesc_ReturnsCorrectSum()
    {
      int[] array = new int[5] { 5, 4, 3, 2, 1 };
      int result = MaxSumOfTwoPairs.FindSecondLargestMaxOfTwoPairs(array);

      Assert.AreEqual(8, result);
    }
  }
}
