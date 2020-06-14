using System;

namespace NullableTypes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today;
        }
    }
}