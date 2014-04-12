using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;

namespace CodingProblemsTests
{
  [TestClass]
  public class LimitedCharReplaceTests
  {
    [TestMethod]
    public void CharReplace_AllBChar_ArrayShouldBeEmpty()
    {
      char[] array = "bbbb".ToCharArray();
      char[] modified = LimitedCharReplace.ReplaceCharacters(array);

      CollectionAssert.AreEqual("    ".ToCharArray(), modified);
    }
    
    [TestMethod]
    public void CharReplace_AllAChar_ArrayShouldBeAllDs()
    {
      char[] array = "aa  ".ToCharArray();
      char[] modified = LimitedCharReplace.ReplaceCharacters(array);

      CollectionAssert.AreEqual("dddd".ToCharArray(), modified);
    }

    [TestMethod]
    public void CharReplace_AlternateABChar_ArrayShouldBeAllDs()
    {
      char[] array = "ababab".ToCharArray();
      char[] modified = LimitedCharReplace.ReplaceCharacters(array);

      CollectionAssert.AreEqual("dddddd".ToCharArray(), modified);
    }


    [TestMethod]
    public void CharReplace_AllCharMixedCharacters_ArrayShouldBeAllCorrect()
    {
      char[] array = "addcbbbbabaddaa".ToCharArray();
      char[] modified = LimitedCharReplace.ReplaceCharacters(array);

      CollectionAssert.AreEqual("ddddcdddddddddd".ToCharArray(), modified);
    }


    [TestMethod]
    public void CharReplace_AllCChar_ArrayShouldTheSame()
    {
      char[] array = "ccccc".ToCharArray();
      char[] modified = LimitedCharReplace.ReplaceCharacters(array);

      CollectionAssert.AreEqual("ccccc".ToCharArray(), modified);
    }

    [TestMethod]
    public void CharReplace_CharArrayWillHaveSpace_ArrayShouldBeShifted()
    {
      char[] array = "bba".ToCharArray();
      char[] modified = LimitedCharReplace.ReplaceCharacters(array);

      CollectionAssert.AreEqual("dd ".ToCharArray(), modified);
    }
  }
}
