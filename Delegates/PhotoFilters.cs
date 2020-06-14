using System;

namespace Delegates
{
    internal partial class Program
    {
        public class PhotoFilters
        {
            public void ApplyBrightess(Photo photo)
            {
                Console.WriteLine("Applying brightness");
            }

            public void AppyContrast(Photo photo)
            {
                Console.WriteLine("Applying contrast");
            }

            public void Resize(Photo photo)
            {
                Console.WriteLine("Resising photo");
            }
        }
    }
}