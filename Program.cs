using System;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace PrimeSifting
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Prime Number Sifting!");
      Console.WriteLine("We'll return all the prime numbers between two to the provided numbers.");
      int providedNumber = IsNumber();
      List<int> primes = Prime.GetPrimes(providedNumber);
      string result = string.Join(",", primes);
      Console.WriteLine($"Here are the prime numbers: {result}");
    }

    public static int IsNumber()
    {
      int number = 0;
      Console.WriteLine("Please enter a positive whole number bigger than 1.");
      bool userInput = Int32.TryParse(Console.ReadLine(), out number);
      if(!userInput)
      {
        Console.WriteLine("\nWe only accept a number.");
        return IsNumber();
      }
      if (number <= 1)
      {
        Console.WriteLine("\nWe only accept a number bigger than 2.");
        return IsNumber();
      }
      return number;
    }
  }
}