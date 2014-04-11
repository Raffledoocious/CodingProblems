using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
  public class Spiral2DList
  {
    public static List<int> Print2DArrayToSpiralList(int[,] array)
    {
      // tset
      List<int> spiralList = new List<int>();
      int totalCount = array.GetLength(0) * array.GetLength(1);
      int printCount = 0;
      int leftBound = 0;
      int topBound = 0;
      int rightBound = array.GetLength(1) - 1;
      int bottomBound = array.GetLength(0) - 1;

      while (printCount < totalCount)
      {
        if (leftBound == rightBound  && leftBound == topBound  && leftBound == bottomBound)
        {
          spiralList.Add(array[leftBound, bottomBound]);
          printCount++;
        }

        for (int i = leftBound; i < rightBound; i++)
        {
          spiralList.Add(array[topBound, i]);
          printCount++;
        }

        for(int j = topBound; j < bottomBound; j++)
        {
          spiralList.Add(array[j, rightBound]);
          printCount++;
        }

        for(int k = rightBound; k > leftBound; k--)
        {
          spiralList.Add(array[bottomBound, k]);
          printCount++;
        }


        for(int m = bottomBound; m > topBound; m--)
        {
          spiralList.Add(array[m, leftBound]);
          printCount++;
        }

        rightBound--;
        bottomBound--;
        topBound++;
        leftBound++;
      }

      return spiralList;
    }
  }
}
