using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
  public class GetBitCount
  {
    /// <summary>
    /// Given an integer from Int.Min to Int.Max, 
    /// returns the number of bits set to 1 within it
    /// </summary>
    /// <param name="i">int to count bits in</param>
    /// <returns>number of bits set to 1</returns>
    public static int GetBitCountFromInt(int num)
    {
      int bitCount = 0;
      //account for 1 in negative signed integers
      if (num < 0)
      {
        bitCount++;
        //if we are given smallest int
        //increment and then use the largest int
        if ( num == int.MinValue)
        {
          num = int.MaxValue;
        }
        else
        {
          num *= -1;
        }
      }

      int currentExponent = (int) Math.Floor(Math.Log(num) / Math.Log(2));
      for (int i = currentExponent; currentExponent >= 0; currentExponent--)
      {
        int currentNum = (int) Math.Pow(2, currentExponent);
        if (num >= currentNum)
        {
          bitCount++;
          num -= currentNum;
        }
      }

      return bitCount;
    }
  }
}
