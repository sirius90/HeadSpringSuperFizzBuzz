using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzLibrary.Models
{
    public class DivisorToken
    {
        public int Divisor { get; set; }
        public string Token{ get; set; }

        public DivisorToken(int divisor, string token)
        {
            Divisor = divisor;
            Token = token;

        }

    }
}
