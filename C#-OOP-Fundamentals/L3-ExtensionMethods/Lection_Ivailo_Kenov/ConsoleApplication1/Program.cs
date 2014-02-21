using System;
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
            Task task = Task.Run(() => { throw null; });

            try
            {
                task.Wait();
            }
            catch (AggregateException ae)
            {
                if (ae.InnerException is NullReferenceException)
                    Console.WriteLine("Null!");
                else
                    Console.WriteLine("Exception!");
            }

            Console.ReadLine();
        }
    }
}
