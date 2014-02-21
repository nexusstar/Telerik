namespace _01_02_ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public static class IEnumerableExtension
    {

        public static T Sum<T>(this IEnumerable<T> collection)
        {
            dynamic sum = default(T);

            if (collection.First() is ValueType) //collection.First() will throw exception if collection is empty
            {
                foreach (T item in collection)
                {
                    sum += item;
                }

                return (T)sum;
            }

            else
            {
                foreach (T item in collection)
                {
                    sum += item;
                }

                return sum; 
            }
        }
        public static T Product<T>(this IEnumerable<T> collection)
        {
            dynamic product;

            if (collection.First() is ValueType) //collection.First() will throw exception if collection is empty
            {
                product = 1;
                foreach (var item in collection)
                {
                    product *= item;
                }
                return (T)product;
            }

            else
            {
                throw new InvalidOperationException("This method could not be used for this type of data");
            }
        }

        public static T Average<T>(this IEnumerable<T> collection)
        {
            if (collection.First() is ValueType) //collection.First() will throw exception if collection is empty 
            {
                dynamic sum = Sum(collection);
                return (T)(sum /collection.Count());
            }
            else
            {
                throw new InvalidOperationException("This method could not be used for this type of data");
            }
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable<T>
        {
            T minValue = collection.First();

            foreach (T item in collection)
            {
                if (item.CompareTo(minValue) < 0)
                {
                    minValue = item;
                }
            }

            return minValue;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable<T>
        {
            T maxValue = collection.First();

            foreach (T item in collection)
            {
                if (item.CompareTo(maxValue) > 0)
                {
                    maxValue = item;
                }
            }

            return maxValue;
        }
    }
}
