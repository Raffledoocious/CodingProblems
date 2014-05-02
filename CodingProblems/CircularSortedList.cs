using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
  public class CircularSortedList
  {
    /// <summary>
    /// Problem 11.5
    /// </summary>
    /// <param name="circularList">the circular list to find element in</param>
    /// <returns>the index of the smallest element</returns>
    public static int FindSmallestElementInList(int[] circularList)
    {
      int leftBound = 0;
      int rightBound = circularList.Length - 1;
      int middleIndex = circularList.Length / 2;

      while (leftBound < rightBound && leftBound < middleIndex && rightBound > middleIndex)
      {
        // element must be in left portion of array
        if (circularList[middleIndex] < circularList[leftBound])
        {
          rightBound = middleIndex;
          middleIndex = (middleIndex - leftBound) / 2;
        }

        // must be in right portion of the array
        else if (circularList[rightBound] < circularList[middleIndex])
        {
          leftBound = middleIndex;
          middleIndex = ((rightBound - middleIndex) / 2) + middleIndex;
        }

        // handling edge case where array is sorted
        else
        {
          rightBound = middleIndex;
          middleIndex = (middleIndex - leftBound) / 2;
        }
      }

      // determine smallest element
      if (circularList[middleIndex] <= circularList[leftBound] && circularList[middleIndex] <= circularList[rightBound])
      {
        return middleIndex;
      }
      if (circularList[rightBound] <= circularList[leftBound] && circularList[rightBound] <= circularList[middleIndex])
      {
        return rightBound;
      }
      else
      {
        return leftBound;
      }
    }
  }
}
