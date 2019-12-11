using System.Collections.Generic;

namespace PrimeSifting.Models
{
  class Prime
  {
    public static List<int> GetPrimes(int number)
    {
      // loop through each numbers in the list, add prime number to the list, primes.
      List<int> primes = new List<int>();
      bool isPrime = true;
      for (int i = 2; i <= number; i++)
      {
        for (int j = 2; j <= number; j++)
        {
          if (i != j && i % j == 0)
          {
            isPrime = false;
            break;
          }
        }
        if (isPrime)
        {
          primes.Add(i);
        }
        isPrime = true;
      }
      return primes;
    }
  }
}
