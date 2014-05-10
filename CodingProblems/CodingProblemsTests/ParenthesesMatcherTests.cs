using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;

namespace CodingProblemsTests
{
  [TestClass]
  public class ParenthesesMatcherTests
  {
    [TestMethod]
    public void Matcher_FirstParenthesisIsUnmatched_ReturnsListWithIndex0()
    {
      string expression = "((1+1)=(2)";
      int[] indices = ParenthesesMatcher.FindUnmatchedParentheses(expression);

      Assert.AreEqual(1, indices.Length);
      Assert.AreEqual(0, indices[0]);
    }

    [TestMethod]
    public void Matcher_ParenthesisUnmatchedInMiddle_ReturnsListWithCorrectIndex()
    {
      string expression = "(1+1)((2+1)";
      int[] indices = ParenthesesMatcher.FindUnmatchedParentheses(expression);

      Assert.AreEqual(1, indices.Length);
      Assert.AreEqual(5, indices[0]);
    }

    [TestMethod]
    public void Matcher_ParenthesisUnmatchedAtEnd_ReturnsListWithCorrectIndex()
    {
      string expression = "(1+1)(2+1))";
      int[] indices = ParenthesesMatcher.FindUnmatchedParentheses(expression);

      Assert.AreEqual(1, indices.Length);
      Assert.AreEqual(10, indices[0]);
    }

    [TestMethod]
    public void Matcher_MultipleParenthesisScatteredAbout_ReturnsListWithCorrectIndices()
    {
      string expression = ")(1+1))+(1+2)))";
      int[] indices = ParenthesesMatcher.FindUnmatchedParentheses(expression);
      int[] expectedIndices = new int[4] { 14, 13, 6, 0 };
      Assert.AreEqual(4, indices.Length);
      CollectionAssert.AreEqual(expectedIndices, indices);
    }

    [TestMethod]
    public void Matcher_MultipleParenthesisAtEnd_ReturnsListWithCorrectIndices()
    {
      string expression = "(1+1)+2(2*3))))";
      int[] indices = ParenthesesMatcher.FindUnmatchedParentheses(expression);

      int[] expectedIndices = new int[3] { 14, 13, 12 };

      Assert.AreEqual(3, indices.Length);
      CollectionAssert.AreEqual(expectedIndices, indices);
    }

    [TestMethod] 
    public void Matcher_MultipleParenthesisAtBeginning_ReturnsListWithCorrectIndices()
    {
      string expression = "((((1+1)+2(2*3)";
      int[] indices = ParenthesesMatcher.FindUnmatchedParentheses(expression);

      int[] expectedIndices = new int[3] { 2, 1, 0 };

      Assert.AreEqual(3, indices.Length);
      CollectionAssert.AreEqual(expectedIndices, indices);
    }

    [TestMethod]
    public void Matcher_NoUnmatchedParenthesis_ReturnsEmptyList()
    {
      string expression = "(1+1) = (1+1)";
      int[] indices = ParenthesesMatcher.FindUnmatchedParentheses(expression);

      Assert.AreEqual(0, indices.Length);
    }
  }
}
