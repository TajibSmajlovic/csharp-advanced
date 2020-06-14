using System;

namespace Delegates
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightess;
            filterHandler += filters.AppyContrast;
            filterHandler += AppyRedEye;

            processor.Process("nekiImidz.jpg", filterHandler);
        }

        private static void AppyRedEye(Photo photo)
        {
            Console.WriteLine("Red eye");
        }
    }
}