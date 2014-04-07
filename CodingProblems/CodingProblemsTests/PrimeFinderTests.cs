using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CodingProblems;

namespace CodingProblemsTests
{
  [TestClass]
  public class PrimeFinderTests
  {
    [TestMethod]
    public void FindPrimes_7_ShouldReturn_2_3_5_7()
    {
      int x = 7;
      List<int> primes = PrimeFinder.FindPrimes(11);
      List<int> expectedPrimes = new List<int>() { 2, 3, 5, 7, 11 };
      CollectionAssert.AreEqual(expectedPrimes, primes);
    }

    [TestMethod]
    public void FindPrimes_11_ShouldReturn_2_3_5_7_11()
    {
      int x = 11;
      List<int> primes = PrimeFinder.FindPrimes(11);
      List<int> expectedPrimes = new List<int>() { 2, 3, 5, 7, 11 };
      CollectionAssert.AreEqual(expectedPrimes, primes);
    }

    [TestMethod]
    public void FindPrimes_150_ShouldReturnAllPrimes()
    {
      int x = 150;
      List<int> primes = PrimeFinder.FindPrimes(150);
      List<int> expectedPrimes = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 
                                                   43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 
                                                   101, 103, 107, 109, 113, 127, 131, 137, 139, 149 };
      CollectionAssert.AreEqual(expectedPrimes, primes);
    }

    [TestMethod]
    public void FindPrimes_LargeNumber_NumberIsPrime_ShouldReturnAllPrimes()
    {
      int x = 146;
      List<int> primes = PrimeFinder.FindPrimes(146);
      List<int> expectedPrimes = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 
                                                   43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 
                                                   101, 103, 107, 109, 113, 127, 131, 137, 139 };
      CollectionAssert.AreEqual(expectedPrimes, primes);
    }
  }
}
