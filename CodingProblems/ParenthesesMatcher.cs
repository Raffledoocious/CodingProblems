using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
  /// <summary>
  /// Find unmatched parenthesis in a given string expression
  /// </summary>
  public static class ParenthesesMatcher
  {
    /// <summary>
    /// Given a string expression, finds all indices of unmatched parenthesis 
    /// </summary>
    /// <param name="matchString">expression</param>
    /// <returns>list of indices in the string containing an unmatched parenthesis</returns>
    public static int[] FindUnmatchedParentheses(string matchString)
    {
      //data structures to hold index and chars
      Stack<int> indiceStack = new Stack<int>();
      Stack<char> parenthesesStack = new Stack<char>();

      for (int i = 0; i < matchString.Length; i++)
      {
        if (matchString[i] == '(' || matchString[i] == ')')
        {
          //if the character on top of the stack is a '(' and current char is a ')'
          //we have matching parentheses and can pop off the stack
          if (parenthesesStack.Count > 0 && parenthesesStack.Peek() == '(' && matchString[i] == ')')
          {
            indiceStack.Pop();
            parenthesesStack.Pop();
          }
          //otherwise we do not have a match, so push onto the stacks
          else
          {
            indiceStack.Push(i);
            parenthesesStack.Push(matchString[i]);
          }
        }
      }

      return indiceStack.ToArray();
    }
  }
}
