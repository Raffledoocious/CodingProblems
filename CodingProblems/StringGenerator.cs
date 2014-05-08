using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
  /// <summary>
  /// From HackerNews interview question
  /// Given a function which takes a list of characters and an integer,
  /// generate all combinations of characters
  /// </summary>
  public static class StringGenerator
  {
    private static List<string> genStrings;
    public static List<string> GenerateCharacterCombinations(List<char> characters, int length)
    {
      genStrings = new List<string>();
      GenerateCombinations(characters, length, "", length);
      return genStrings;
    }

    private static void GenerateCombinations(List<char> characters, int length, string p, int originalLength)
    {
      if (length <= 0)
      {
        genStrings.Add(p);
        return;
      }

      for (int i = 0; i < characters.Count; i++)
      {
        if (length != originalLength)
        {
          GenerateCombinations(characters, length - 1, p + characters[i], originalLength);
        }
        else
        {
          GenerateCombinations(characters, length - 1, "" + characters[i], originalLength);
        }         
      }
    }
  }
}
