using System;
using System.Collections.Generic;
using FizzBuzzLibrary;
using FizzBuzzLibrary.Models;

namespace Classic_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var listTokens = new List<DivisorToken>();

            var divisorToken1 = new DivisorToken(3, "Fizz");
            var divisorToken2 = new DivisorToken(5, "Buzz");

            listTokens.Add(divisorToken1);
            listTokens.Add(divisorToken2);

            var classicFizzBuzz = new SuperFizzBuzz(new IntRange(1,100), null, listTokens);

            classicFizzBuzz.FizzBuzz();

        }
    }
}
