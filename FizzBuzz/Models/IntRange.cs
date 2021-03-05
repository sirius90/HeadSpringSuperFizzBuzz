using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzLibrary.Models
{
    public class IntRange
    {
        public int Begin { get; set; }
        public int End { get; set; }

        public IntRange(int begin, int end)
        {
            Begin = begin;
            End = end;
        }

    }
}
