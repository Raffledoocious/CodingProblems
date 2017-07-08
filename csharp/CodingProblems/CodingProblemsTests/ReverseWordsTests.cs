using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;

namespace CodingProblemsTests
{
  [TestClass]
  public class ReverseWordsInStringTests
  {
    [TestMethod]
    public void ReverseWords_SingleWord_ShouldReturnSameWord()
    {
      char[] sentence = "Alice".ToCharArray();
      char[] reverse = ReverseWords.ReverseWordsInCharArray(sentence);
      CollectionAssert.AreEqual(sentence, reverse);
    }

    [TestMethod]
    public void ReverseWords_TwoWords_SingleSpace_ReturnsWordsReversed()
    {
      char[] sentence = "Alice Likes Bob".ToCharArray();
      char[] reverse = ReverseWords.ReverseWordsInCharArray(sentence);
      CollectionAssert.AreEqual("Bob Likes Alice".ToCharArray(), reverse);
    }

    [TestMethod]
    public void ReverseWords_MultipleWords_SingleSpace_ReturnsWordsReversed()
    {
      char[] sentence = "Alice Likes Bob and woo hoo".ToCharArray();
      char[] reverse = ReverseWords.ReverseWordsInCharArray(sentence);
      CollectionAssert.AreEqual("hoo woo and Bob Likes Alice".ToCharArray(), reverse);
    }

    [TestMethod]
    public void ReverseWords_EveryOtherASpace_SingleSpace_ReturnsWordsReversed()
    {
      char[] sentence = " A b c d e f g ".ToCharArray();
      char[] reverse = ReverseWords.ReverseWordsInCharArray(sentence);
      CollectionAssert.AreEqual(" g f e d c b A ".ToCharArray(), reverse);
    }

    [TestMethod]
    public void ReverseWords_MultipleWhiteSpaces_ReturnsWordsReversed()
    {
      char[] sentence = " A b c d e f g    hi there I am    a  cow   ".ToCharArray();
      char[] reverse = ReverseWords.ReverseWordsInCharArray(sentence);
      CollectionAssert.AreEqual("   cow  a    am I there hi    g f e d c b A ".ToCharArray(), reverse);
    }
  }
}
