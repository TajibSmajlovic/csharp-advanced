using System;

namespace LambdaExpressions
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            Func<int, int> square = number => number * number;

            Console.WriteLine(square(2));
        }
    }
}