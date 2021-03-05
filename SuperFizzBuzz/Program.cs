using System;
using System.Collections.Generic;
using FizzBuzzLibrary;
using FizzBuzzLibrary.Models;

namespace SuperFizzBuzz1
{
    class Program
    {
        static void Main(string[] args)
        {
            var listTokens = new List<DivisorToken>();

            var divisorToken1 = new DivisorToken(3, "Fizz");
            var divisorToken2 = new DivisorToken(7, "Buzz");
            var divisorToken3 = new DivisorToken(38, "Bazz");

            listTokens.Add(divisorToken1);
            listTokens.Add(divisorToken2);
            listTokens.Add(divisorToken3);

            var superFizzBuzz = new SuperFizzBuzz(new IntRange(-12, 145), null, listTokens);

            superFizzBuzz.FizzBuzz();
        }
    }
}
