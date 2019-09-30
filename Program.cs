using System;
using PrimeSifting.Models;

namespace PrimeSifting
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Prime Number Sifting!");
      Console.WriteLine("We'll return all the prime numbers between two to the provided numbers.");
      isNumber();
    }

    public static int isNumber()
    {
        Console.WriteLine("Please enter a number");
      int number = 0;
      bool userInput = Int32.TryParse(Console.ReadLine(), out number);
      if(!userInput)
      {
        Console.WriteLine("\nPlease enter a number!");
        return isNumber();
      }
      return number;
    }
  }
}