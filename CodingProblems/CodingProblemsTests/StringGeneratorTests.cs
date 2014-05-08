using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;
using System.Collections.Generic;

namespace CodingProblemsTests
{
  [TestClass]
  public class StringGeneratorTests
  {
    [TestMethod]
    public void StringGen_TwoCharacters_TwoCharactersReturned()
    {
      List<char> chars = new List<char> { 'a', 'b' };
      List<string> genStrings = StringGenerator.GenerateCharacterCombinations(chars, 1);

      Assert.AreEqual(2, genStrings.Count);
      Assert.AreEqual("a", genStrings[0]);
      Assert.AreEqual("b", genStrings[1]);
    }
    
    [TestMethod]
    public void StringGen_ThreeCharacters_LengthThree_CorrectStringsReturned()
    {
      List<char> chars = new List<char> { 'a', 'b', 'c'};
      List<string> genStrings = StringGenerator.GenerateCharacterCombinations(chars, 3);

      Assert.AreEqual(27, genStrings.Count);
      CollectionAssert.Contains(genStrings, "aaa");
      CollectionAssert.Contains(genStrings, "aab");
      CollectionAssert.Contains(genStrings, "aac");
      CollectionAssert.Contains(genStrings, "aba");
      CollectionAssert.Contains(genStrings, "abb");
      CollectionAssert.Contains(genStrings, "abc");
      CollectionAssert.Contains(genStrings, "aca");
      CollectionAssert.Contains(genStrings, "acb");
      CollectionAssert.Contains(genStrings, "acc");
      CollectionAssert.Contains(genStrings, "baa");
      CollectionAssert.Contains(genStrings, "bab");
      CollectionAssert.Contains(genStrings, "bac");
      CollectionAssert.Contains(genStrings, "bba");
      CollectionAssert.Contains(genStrings, "bbb");
      CollectionAssert.Contains(genStrings, "bbc");
      CollectionAssert.Contains(genStrings, "bca");
      CollectionAssert.Contains(genStrings, "bcb");
      CollectionAssert.Contains(genStrings, "bcc");
      CollectionAssert.Contains(genStrings, "caa");
      CollectionAssert.Contains(genStrings, "cab");
      CollectionAssert.Contains(genStrings, "cac");
      CollectionAssert.Contains(genStrings, "cba");
      CollectionAssert.Contains(genStrings, "cbb");
      CollectionAssert.Contains(genStrings, "cbc");
      CollectionAssert.Contains(genStrings, "cca");
      CollectionAssert.Contains(genStrings, "ccb");
      CollectionAssert.Contains(genStrings, "ccc");
    }

    [TestMethod]
    public void StringGen_ThreeCharacters_LengthTwo_CorrectStringsReturned()
    {
      List<char> chars = new List<char> { 'a', 'b', 'c' };
      List<string> genStrings = StringGenerator.GenerateCharacterCombinations(chars, 2);

      Assert.AreEqual(9, genStrings.Count);
      CollectionAssert.Contains(genStrings, "aa");
      CollectionAssert.Contains(genStrings, "ab");
      CollectionAssert.Contains(genStrings, "ac");
      CollectionAssert.Contains(genStrings, "ba");
      CollectionAssert.Contains(genStrings, "bb");
      CollectionAssert.Contains(genStrings, "bc");
      CollectionAssert.Contains(genStrings, "ca");
      CollectionAssert.Contains(genStrings, "cb");
      CollectionAssert.Contains(genStrings, "cc");
    }
  }
}
