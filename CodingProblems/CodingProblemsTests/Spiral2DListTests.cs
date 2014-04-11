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
  }
}
