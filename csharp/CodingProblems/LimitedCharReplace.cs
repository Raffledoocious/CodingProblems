using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
  /// <summary>
  /// Problem 6.21
  /// </summary>
  public class LimitedCharReplace
  {
    public static char[] ReplaceCharacters(char[] array)
    {

      array = ReplaceBAndShiftArray(array);
      array = ReplaceAWithDD(array);
      return array;
    }

    /// <summary>
    /// Removes all 'b' characters in the array and shifts characters over 
    /// resulting in a final array with all 'b' characters removed
    /// </summary>
    /// <param name="array">the array to remove characters from</param>
    /// <returns>array with 'b' char removed</returns>
    private static char[] ReplaceBAndShiftArray(char[] array)
    {
      int startPtr = 0;
      while (startPtr < array.Length)
      {
        while (array[startPtr] == 'b')
        {
          int prevPtr = startPtr;
          for (int i = prevPtr + 1; i < array.Length; i++)
          {
            array[prevPtr] = array[i];
            prevPtr++;
          }
          array[prevPtr] = ' ';
        }
        startPtr++;
      }
      return array;
    }

    /// <summary>
    /// Given an array, replaces 'a' character with 'dd',
    /// other characters are shifted.
    /// </summary>
    /// <param name="array">array to replace characters in</param>
    /// <returns>array with 'a' replaced by 'dd'</returns>
    private static char[] ReplaceAWithDD(char[] array)
    {
      int endPtr = array.Length - 1;
      int startPtr = FindFirstSpace(array) - 1;

      //replace all characters
      while (startPtr >= 0)
      {
        if (array[startPtr] == 'a')
        {
          array[startPtr] = ' ';
          array[endPtr] = 'd';
          array[endPtr - 1] = 'd';
          endPtr -= 2;
          startPtr--;
        }
        else
        {
          array[endPtr] = array[startPtr];
          endPtr--;
          startPtr--;
        }
      }

      //shift the array forward
      if (endPtr >= 0)
      {
        endPtr++;
        int shiftPtr = 0;
        for (int i = endPtr; i < array.Length; i++)
        {
          array[shiftPtr] = array[i];
          array[i] = ' ';
          shiftPtr++;
        }
      }

      return array;

    }

    private static int FindFirstSpace(char[] array)
    {
      int index = 0;
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] == ' ')
        {
          index = i;
          break;
        }
      }
      return index;
    }
  }
}
