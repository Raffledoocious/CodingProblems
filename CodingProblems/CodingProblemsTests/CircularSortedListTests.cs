using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;

namespace CodingProblemsTests
{
  [TestClass]
  public class CircularSortedListTests
  {
    [TestMethod]
    public void CircularList_OneElement_ReturnsIndex0()
    {
      int[] array = new int[1] { 1 };
      int smallestIndex = CircularSortedList.FindSmallestElementInList(array);
      Assert.AreEqual(0, smallestIndex);
    }

    [TestMethod]
    public void CircularList_TwoElements_SmallestFirst_Returns0()
    {
      int[] array = new int[2] { 1, 2 };
      int smallestIndex = CircularSortedList.FindSmallestElementInList(array);
      Assert.AreEqual(0, smallestIndex);
    }

    [TestMethod]
    public void CircularList_ThreeElements_SmallestFirst_Returns0()
    {
      int[] array = new int[3] { 1, 2, 3 };
      int smallestIndex = CircularSortedList.FindSmallestElementInList(array);
      Assert.AreEqual(0, smallestIndex);
    }

    [TestMethod]
    public void CircularList_ThreeElements_SmallestMiddle_Returns1()
    {
      int[] array = new int[3] { 3, 1, 2 };
      int smallestIndex = CircularSortedList.FindSmallestElementInList(array);
      Assert.AreEqual(1, smallestIndex);      
    }

    [TestMethod]
    public void CircularList_ThreeElements_SmallestLast_Returns2()
    {
      int[] array = new int[3] { 2, 3, 1 };
      int smallestIndex = CircularSortedList.FindSmallestElementInList(array);
      Assert.AreEqual(2, smallestIndex);
    }

    [TestMethod]
    public void CircularList_SevenElements_SmallestFirst_Returns0()
    {
      int[] array = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
      int smallestIndex = CircularSortedList.FindSmallestElementInList(array);
      Assert.AreEqual(0, smallestIndex);
    }

    [TestMethod]
    public void CircularList_SevenElements_SmallestSecond_Returns1()
    {
      int[] array = new int[7] { 9, 1, 3, 4, 5, 6, 7 };
      int smallestIndex = CircularSortedList.FindSmallestElementInList(array);
      Assert.AreEqual(1, smallestIndex);
    }

    [TestMethod]
    public void CircularList_SevenElements_SmallestThird_Returns2()
    {
      int[] array = new int[7] { 9, 10, 1, 4, 5, 6, 7 };
      int smallestIndex = CircularSortedList.FindSmallestElementInList(array);
      Assert.AreEqual(2, smallestIndex);
    }

    [TestMethod]
    public void CircularList_SevenElements_SmallestFourth_Returns3()
    {
      int[] array = new int[7] { 9, 10, 11, 1, 5, 6, 7 };
      int smallestIndex = CircularSortedList.FindSmallestElementInList(array);
      Assert.AreEqual(3, smallestIndex);
    }

    [TestMethod]
    public void CircularList_SevenElements_SmallestFifth_Returns4()
    {
      int[] array = new int[7] { 9, 10, 30, 40, 1, 6, 7 };
      int smallestIndex = CircularSortedList.FindSmallestElementInList(array);
      Assert.AreEqual(4, smallestIndex);
    }

    [TestMethod]
    public void CircularList_SevenElements_SmallestSixth_Returns5()
    {
      int[] array = new int[7] { 9, 10, 30, 40, 100, 1, 7 };
      int smallestIndex = CircularSortedList.FindSmallestElementInList(array);
      Assert.AreEqual(5, smallestIndex);
    }

    [TestMethod]
    public void CircularList_SevenElements_SmallestSeventh_Returns6()
    {
      int[] array = new int[7] { 9, 10, 30, 40, 100, 1000, 1 };
      int smallestIndex = CircularSortedList.FindSmallestElementInList(array);
      Assert.AreEqual(6, smallestIndex);
    }
  }
}
