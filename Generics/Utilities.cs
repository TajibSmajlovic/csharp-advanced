using System;

namespace Generics
{
    // where T : IComparable
    // where T : Product(class)
    // where T : struct
    // where T : class
    // where T : new()
    internal partial class Program
    {
        public class Utilities<T> where T : IComparable, new()
        {
            public T Max(T a, T b)
            {
                return a.CompareTo(b) > 0 ? a : b;
            }

            public void DoSomehing(T value)
            {
                var obj = new T();
            }
        }
    }
}