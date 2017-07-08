using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    /// <summary>
    /// Problem 5.3
    /// </summary>
    public static class BitReversal
    { 
      private static int BIT_COUNT;

      /// <summary>
      /// Given an 64bit unsigned integer and a bit count, returns the 
      /// value of the integer if the bits were reversed.
      /// </summary>
      /// <param name="x">Unsigned 64bit integer to convert</param>
      /// <param name="bitCount">number of bits to swap</param> 
      public static ulong GetLongWithBitsReversed(ulong x, int bitCount)
      {
        BIT_COUNT = Math.Abs(bitCount);
        bool[] bits = ConvertLongToBitArray(x);
        bool[] reverse = new bool[BIT_COUNT];

        for (int i = 0; i < BIT_COUNT; i++)
        {
          reverse[i] = bits[(BIT_COUNT - 1) - i];
        }

        ulong reversedLong = ConvertBitArrayToLong(reverse);
        return reversedLong;
      }

      /// <summary>
      /// Given a boolean array representing bits, returns 
      /// an unsigned integer value
      /// </summary>
      /// <param name="reverse">the boolean array</param>
      /// <returns>Unsigned 64bit integer</returns>
      private static ulong ConvertBitArrayToLong(bool[] reverse)
      {
        ulong convertedLong = 0;

        for (int i = 0; i < BIT_COUNT; i++)
        {
          if (reverse[i])
          {
            convertedLong += Convert.ToUInt64(Math.Pow(2, i));
          }
        }

        return convertedLong;
      }

      /// <summary>
      /// Given a unsigned 64Bit integer x, returns 
      /// a bit array representation of the integer
      /// </summary>
      /// <param name="x"></param>
      /// <returns>bit array representation</returns>
      private static bool[] ConvertLongToBitArray(ulong x)
      {
        bool[] bitArray = new bool[BIT_COUNT];

        for (int i = BIT_COUNT - 1; i >= 0; i--)
        {
          ulong compLong = Convert.ToUInt64(Math.Pow(2, i));
          if (x >= compLong)
          {
            x -= compLong;
            bitArray[i] = true;
          } 
        }

        return bitArray;
      }
    }
}
