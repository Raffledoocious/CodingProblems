using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
  public struct MinMaxResult {
    public int min, max;

    public MinMaxResult(int min, int max)
    {
      this.min = min;
      this.max = max;
    }
  }

  public class BitMinMaxFinder
  {
    public static MinMaxResult FindMinMaxBasedOnBitCount(int i)
    {
      bool[] bits = ConvertToBitArray(i);
      int maxInt = GetMaxInt(bits);
      int minInt = GetMinInt(bits);
      return new MinMaxResult(minInt, maxInt);
    }

    private static int GetMinInt(bool[] origBits)
    {
      bool[] bits = (bool[])origBits.Clone();
      int lastOne = -1;
      for (int i = bits.Length - 2; i >= 0; i--)
      {
        if (bits[i])
        {
          lastOne = i;
          break;
        }
      }

      int lastZero = -1;
      for (int i = lastOne; i >= 0; i--)
      {
        if (!bits[i])
        {
          lastZero = i;
          break;
        }
      }

      if (lastZero == -1)
      {
        bits = ConvertBitArrayToSmallestNegative(bits, lastOne);
      }
      else
      {
        bits[lastOne] = !bits[lastOne];
        bits[lastZero] = !bits[lastZero];
      }

      return ConvertBitArrayToInt(bits);
    }

    private static bool[] ConvertBitArrayToSmallestNegative(bool[] bits, int lastOne)
    {
      for (int i = 0; i <= lastOne; i++)
      {
        bits[lastOne - i] = false;
        bits[bits.Length - i - 1] = true;
      }

      return bits;
    }

    private static int GetMaxInt(bool[] origBits)
    {
      bool[] bits = (bool[]) origBits.Clone();
      int firstOne = -1;
      for (int i = 0; i < bits.Length; i++)
      {
        if (bits[i])
        {
          firstOne = i;
          break;
        }
      }

      int firstZero = -1;
      for (int i = firstOne; i < bits.Length; i++)
      {
        if (!bits[i]) 
        {
          firstZero = i;
          break;
        }
      }

      int origInt = ConvertBitArrayToInt(origBits);
      if (origInt % 2 != 0 && origInt != int.MaxValue)
      {
        bits[firstZero - 1] = false;
        bits[firstZero] = true;
      }
      else if (firstZero != 31)
      {
        bits[firstOne] = !bits[firstOne];
        bits[firstZero] = !bits[firstZero];
      }

      return ConvertBitArrayToInt(bits);
    }

    private static bool[] ConvertToBitArray(int i)
    {
      BitArray b = new BitArray(new int[] { i });
      bool[] bools = new bool[b.Length];
      b.CopyTo(bools, 0);
      return bools;
    }

    private static int ConvertBitArrayToInt(bool[] bits)
    {
      BitArray b = new BitArray(bits);
      int[] intArr = new int[1];
      b.CopyTo(intArr, 0);
      return intArr[0];
    }
  }
}
