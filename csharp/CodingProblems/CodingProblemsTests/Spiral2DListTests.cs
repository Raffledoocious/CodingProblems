using CodingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemsTests
{
  [TestClass]
  public class Spiral2DListTests
  {
    [TestMethod]
    public void Spiral2DList_2by2_CorrectListReturned()
    {
      int[,] array = new int[,] { { 1, 2 }, { 3, 4 } };
      List<int> spiralList = Spiral2DList.Print2DArrayToSpiralList(array);
      List<int> expectedList = new List<int>() { 1, 2, 4, 3 };

      CollectionAssert.AreEqual(expectedList, spiralList);
    }
    [TestMethod]
    public void Spiral2D_List_3by3_CorrectListReturned()
    {
      int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
      List<int> spiralList = Spiral2DList.Print2DArrayToSpiralList(array);
      List<int> expectedList = new List<int>() { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

      CollectionAssert.AreEqual(expectedList, spiralList);
    }

    [TestMethod]
    public void Spiral2D_List_1by1_CorrectListReturned()
    {
      int[,] array = new int[,] { { 1 }};
      List<int> spiralList = Spiral2DList.Print2DArrayToSpiralList(array);
      List<int> expectedList = new List<int>() { 1 };

      CollectionAssert.AreEqual(expectedList, spiralList);
    }

    [TestMethod]
    public void Spiral2D_List_4by2_CorrectListReturned()
    {
      int[,] array = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }};
      List<int> spiralList = Spiral2DList.Print2DArrayToSpiralList(array);
      List<int> expectedList = new List<int>() { 1, 2, 3, 4, 8, 7, 6, 5 };

      CollectionAssert.AreEqual(expectedList, spiralList);
    }
    
    [TestMethod]
    public void Spiral2D_List_2by4_CorrectListReturned()
    {
      int[,] array = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, };
      List<int> spiralList = Spiral2DList.Print2DArrayToSpiralList(array);
      List<int> expectedList = new List<int>() { 1, 2, 4, 6, 8, 7, 5, 3 };

      CollectionAssert.AreEqual(expectedList, spiralList);
    }

    [TestMethod]
    public void Spiral2D_List_5by5_CorrectListReturned()
    {
      int[,] array = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
      List<int> spiralList = Spiral2DList.Print2DArrayToSpiralList(array);
      List<int> expectedList = new List<int>() { 1, 2, 3, 4, 5, 10, 15, 20, 25, 24, 23, 22, 21, 16, 11, 6, 7, 8, 9, 14, 19, 18, 17, 12, 13};

      CollectionAssert.AreEqual(expectedList, spiralList);
    }
  }
}
