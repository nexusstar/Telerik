namespace _02.HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class Program
    {
        static void Main()
        {

            int studentCount = 10;

            List<Student> students = new List<Student>(HumanTest.CreateStudents(studentCount));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Before sorting");
            Console.WriteLine(new string('-', 40));
            foreach (var st in students)
            {
                Console.WriteLine(st);
            }
            List<Student> sortedStudentsByGrade = students.OrderBy(st => st.Grade).ToList();
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("After sorting");
            Console.WriteLine(new string('-', 40));
            foreach (var st in sortedStudentsByGrade)
            {
                Console.WriteLine(st);
            }

            List<Worker> workers = new List<Worker>(HumanTest.CreateWorkers(studentCount));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Before sorting");
            Console.WriteLine(new string('-', 40));
            foreach (var w in workers)
            {
                Console.WriteLine(w);
            }
            List<Worker> sortedWorkersByPay = workers.OrderBy(w => w.GetMonneyPerHour()).ToList();
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("After sorting");
            Console.WriteLine(new string('-', 40));
            foreach (var w in sortedWorkersByPay)
            {
                Console.WriteLine(w);
            }

            List<Human> studentAndWorkers = sortedStudentsByGrade.Cast<Human>().Concat(sortedWorkersByPay.Cast<Human>()).ToList();
           
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Before sorting");
            Console.WriteLine(new string('-', 40));

            foreach (var h in studentAndWorkers)
            {
                Console.WriteLine(h.FirstName + " "+ h.LastName);
            }

            List<Human> sortedCollection = studentAndWorkers.OrderBy(h => h.FirstName).ToList();
           
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("After sorting");
            Console.WriteLine(new string('-', 40));

            foreach (var h in sortedCollection)
            {
                Console.WriteLine(h.FirstName + " " + h.LastName);
            }
        }
    }
}
