using System;
using System.Collections.Generic;

namespace Dynamic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            dynamic test = "asd";
            test = 1;

            dynamic a = 5;
            dynamic b = 2;
            var c = a + b;
        }
    }
}