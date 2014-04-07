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

      //handle base cases
      if (x >= 2)
      {
        primes.Add(2);
      }
      for (int i = 3; i <= x; i++)
      {
        bool isPrime = true;
        if (i % 2 != 0)
        {
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
