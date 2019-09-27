using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  class Number
  {
    public static void SelectPrime(int inputNumber)
    {
      List<int> numbers = new List<int> {};
      // make a list from 2 to inputNumber
      for (int i = 2; i <= inputNumber; i++)
      {
        numbers.Add(i);
      }

      // Loop through prime number
      for(int j = 2; j < inputNumber; j++)
      {
        if(numbers[j - 2] % j != 0)
        {
          numbers.Remove(j);
        }
      }
    }
  }
}
