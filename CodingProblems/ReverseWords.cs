using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
  /// <summary>
  /// Problem 6.19
  /// </summary>
  public class ReverseWords
  {
     public static char[] ReverseWordsInCharArray(char[] array)
     {
       ReverseArrayInRange(ref array, 0, array.Length - 1);
       int startPtr = 0;
       int endPtr = 0;

       while (endPtr < array.Length)
       {
          while (startPtr < array.Length && !(array[startPtr] != ' '))
         {
           startPtr++;
         }

         endPtr = startPtr;

         while (endPtr < array.Length && array[endPtr] != ' ')
         {
           endPtr++;
         }

         ReverseArrayInRange(ref array, startPtr, endPtr - 1);
         startPtr = endPtr;
       }


       return array;
     }

     private static void ReverseArrayInRange(ref char[] array, int start, int end)
     {
       int dist = (int)Math.Ceiling((decimal)(end - start) / 2);

       for (int i = 0; i < dist; i++)
       {
         char tmp = array[start + i];
         array[start + i] = array[end - i];
         array[end - i] = tmp;
       }
     }
  }
}
