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
  }
}
