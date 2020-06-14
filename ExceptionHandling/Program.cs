using System;
using System.IO;

namespace ExceptionHandling
{
    public class CustomExeption : Exception
    {
        public CustomExeption(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    public class Calculator
    {
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            StreamReader streamReader = null;

            try
            {
                var calculator = new Calculator();
                var res = calculator.Divide(5, 0);

                streamReader = new StreamReader(@"c:\test.zip");
                var content = streamReader.ReadToEnd();
            }
            catch (DivideByZeroException ex)
            {
            }
            catch (ArithmeticException ex)
            {
            }
            catch (Exception)
            {
                Console.WriteLine("Error occured!");
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Dispose();
            }

            try
            {
                using (var test = new StreamReader("asd"))
                {
                    var content = test.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw new CustomExeption("Error msg!", ex);
            }
        }
    }
}