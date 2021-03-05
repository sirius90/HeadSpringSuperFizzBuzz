using FizzBuzzLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzLibrary
{
    public class SuperFizzBuzz : IFizzBuzz
    {
        private IntRange Range { get; set; }
        private List<int> UserIntegers { get; set; }
        private List<DivisorToken> DivisorTokens { get; set; }
        private List<object> Result { get; set; }

        public SuperFizzBuzz(IntRange range = null,
            List<int> userIntegers = null,
            List<DivisorToken> tokenDivisors = null)
        {
            Range = range;
            UserIntegers = userIntegers;
            DivisorTokens = tokenDivisors;
            Result = new List<object>();
        }


        public List<object> FizzBuzz()
        {
            if (Range != null && UserIntegers != null)
            {
                PrintInvalidOperation("Cannot supply both range and list of integers as input.");
            }
            else if (Range != null)
            {
                FizzBuzzRange();
            }
            else if (UserIntegers != null)
            {
                FizzBuzzIntegers();
            }
            else
            {
                PrintInvalidOperation("No input supplied.");
            }

            if (Result.Count > 0) PrintResult();

            return Result;
        }

        private void FizzBuzzRange()
        {
            if (DivisorTokens != null && DivisorTokens.Count > 0)
            {
                for (int i = Range.Begin; i <= Range.End; i++)
                {
                    if (i == 0)
                    {
                        Result.Add(i);
                    }
                    else
                    {
                        GenericFizzBuzz(i);
                    }
                }                
            }
            else
                PrintInvalidOperation("No integers and divisors supplied.");
        }
        private void FizzBuzzIntegers()
        {
            if (DivisorTokens != null && DivisorTokens.Count > 0)
            {
                foreach (var userInt in UserIntegers)
                {
                    if (userInt == 0)
                    {
                        Result.Add(userInt);
                    }
                    else
                    {
                        GenericFizzBuzz(userInt);
                    }
                }
            }
            else
                PrintInvalidOperation("No integers and divisors supplied.");
        }

        #region HelperFunctions       
          
        private void GenericFizzBuzz(int i)
        {
            bool resultFound = false;

            for (int j = 0; j < DivisorTokens.Count; j++)
            {
                for (int k = j+1; k < DivisorTokens.Count; k++)
                {
                    if (i % DivisorTokens[j].Divisor == 0 && i % DivisorTokens[k].Divisor == 0)
                    {
                        Result.Add(DivisorTokens[j].Token + DivisorTokens[k].Token);
                        resultFound = true;
                        break;
                    }
                }
            }
            for (int j = 0; j < DivisorTokens.Count; j++)
            {
                if (i % DivisorTokens[j].Divisor == 0)
                {
                    Result.Add(DivisorTokens[j].Token);
                    resultFound = true;
                    break;
                }
            }

            if (!resultFound)
            {
                Result.Add(i);
            }          
        }

        private void PrintResult()
        {
            foreach (var item in Result)
            {
                Console.WriteLine(item.ToString());
            }
        }
        private void PrintInvalidOperation(string error)
        {
            Console.WriteLine(error);
        }

            #endregion
        }
}
