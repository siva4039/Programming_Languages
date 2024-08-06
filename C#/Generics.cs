using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    
        public class GenericList<T>
        {
            public void Add(T item)
            {

            }

            public T this[int index]
            {
                get
                {
                    throw new NotImplementedException();
                }
            }
        }

        public class GenericDictionary<TKey, TValue>
        {
            public void Add(TKey key, TValue value)
            {

        }
    }
    /// <summary>
    /// where T : IComparable
    /// where T : Product
    /// where T : struct
    /// where T : class
    /// where T : new()
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericConstraints<T> where T : IComparable, new()
    {
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }

    public class Product {
        public string? Title { get; set; }
        public float Price { get; set; }
    }

    public class Book : Product
    {
        public string? Isbn { get; set; }
    }


    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDicount(TProduct product)
        {
            return product.Price;
        }
    }

    public class Nullable<T> where T : struct 
    {
        private object? _value;
        public Nullable(T value)
        {
            _value = value;
        }

        public Nullable()
        {

        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            return HasValue ? (T)_value : default(T);
        }

    }


}
