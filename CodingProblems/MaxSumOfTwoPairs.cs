using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
  public class MaxSumOfTwoPairs
  {
    public static int FindSecondLargestMaxOfTwoPairs(int[] integers)
    {
      //base cases
      if (integers.Length == 1)
      {
        return integers[0];
      }
      else if (integers.Length == 2)
      {
        return integers[0] + integers[1];
      }

      //otherwise iterate
      int max = Int32.MinValue;
      int secondMax = Int32.MinValue;
      int thirdMax = Int32.MinValue;

      for (int i = 0; i < integers.Length; i++)
      {
        if (integers[i] > max)
        {
          thirdMax = secondMax;
          secondMax = max;
          max = integers[i];          
        }
        else if (integers[i] > secondMax && integers[i] < max)
        {
          thirdMax = secondMax;
          secondMax = integers[i];
        }
        else if (integers[i] > thirdMax && integers[i] < secondMax)
        {
          thirdMax = integers[i];
        }
      }

      if (secondMax == int.MinValue)
      {
        return max * 2;
      }
      else if (thirdMax == int.MinValue)
      {
        return max + secondMax;
      }
      else
      {
        return max + thirdMax;
      }


    }
  }
}
