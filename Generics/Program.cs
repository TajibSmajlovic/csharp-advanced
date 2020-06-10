namespace Generics
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(123);

            var test = new GenericList<object>();
            test.Add(new { Name = "asd" });

            var test2 = new GenericDictionary<string, object>();
            test2.Add("asd", new { Name = "asd" });

            var test3 = new Nullable<int>();
            System.Console.WriteLine("Has value: {0}, Value: {1}", test3.HasValue, test3.GetValueOrDefault());
            //var test3 = new Nullable<int>(5);
            //System.Console.WriteLine("Has value: {0}, Value: {1}", test3.HasValue, test3.GetValueOrDefault());
        }
    }
}