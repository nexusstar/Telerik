using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            string searchWord = Console.ReadLine();

            int line = int.Parse(Console.ReadLine());
            int digit;

            var result = new SortedDictionary<int, string>(
                 new ReverseComparer<int>());

            for (int i = 0; i < line; i++)
            {
                int count = 0;

                string[] current = Console.ReadLine().Trim().Split(new char[] { ',', '.', '(', ')', ';', '-', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int word = 0; word < current.Length; word++)
                {

                    if (current[word].ToLower() == searchWord.ToLower())
                    {
                        count++;
                        
                        current[word] = current[word].ToUpperInvariant();
                        
                    }

                }

                StringBuilder builder = new StringBuilder();
                foreach (string value in current)
                {
                    builder.Append(value);
                    builder.Append(' ');
                }
                
                result.Add((result.ContainsKey(count))?++count:count, builder.ToString().Trim());

            }
            foreach (var item in result)
            {
                Console.WriteLine(item.Value);
            }


        }
        public sealed class ReverseComparer<T> : IComparer<T>
        {
            private readonly IComparer<T> inner;
            public ReverseComparer() : this(null) { }
            public ReverseComparer(IComparer<T> inner)
            {
                this.inner = inner ?? Comparer<T>.Default;
            }
            int IComparer<T>.Compare(T x, T y) { return inner.Compare(y, x); }
        }

    }

}