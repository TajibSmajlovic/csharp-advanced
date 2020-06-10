namespace Generics
{
    public class Nullable<T> where T : struct
    {
        private readonly object value;

        public Nullable()
        {
        }

        public Nullable(T value)
        {
            this.value = value;
        }

        public bool HasValue
        {
            get { return value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)value;

            return default(T);
        }
    }
}