namespace Generics
{
    public class Product
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public void Add(TProduct product)
        {
        }
    }
}