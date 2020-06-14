using System;

namespace ExtensionMethods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string post = "This is a very long long long long long post";

            System.Console.WriteLine(post.Shorten(3));
        }
    }
}