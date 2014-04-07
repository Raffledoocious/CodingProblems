using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
  /// <summary>
  /// Problem 5.11
  /// </summary>
  public static class PrimeFinder
  {
    /// <summary>
    /// Finds prime numbers between 2 and x (x must be >= 2).
    /// </summary>
    /// <param name="x"></param>
    /// <returns>a list of prime numbers</returns>
    public static List<int> FindPrimes(int x)
    {
      List<int> primes = new List<int>();

      //handle base cases when 3 <= x <= 7
      if (x >= 2)
      {
        primes.Add(2);
      }
      if (x >= 3)
      {
        primes.Add(3);
      }
      if (x >= 5)
      {
        primes.Add(5);
      }
      if (x >= 7)
      {
        primes.Add(7);
      }
      for (int i = 8; i <= x; i++)
      {
        if (i % 2 != 0)
        {
          bool isPrime = true;
          foreach (int prime in primes)
          {
            if (i % prime == 0)
            {
              isPrime = false;
              break;
            }
          }
          if (isPrime)
          {
            primes.Add(i);
          }
        }
      }

      return primes;
    }
  }
}
