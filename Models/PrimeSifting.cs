using System.Collections.Generic;

namespace PrimeSifting.Models
{
  class Prime
  {
    public static List<int> GetPrimes(int number)
    {
      // create a list of integers based on the inputNumber
      // List<int> numbers = new List<int>();
      // for (int i = 2; i <= number; i++)
      // {
      //   numbers.Add(i);
      // }

      // loop through each numbers in the list, adding each prime number to Primes
      List<int> primes = new List<int>();
      bool isPrime = true;
      for(int i = 2; i <= number; i++)
      {
        for (int j = 2; j <= number; j++)
        {
          if ( i != j && i % j == 0)
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
