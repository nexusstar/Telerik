/*
 * Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
 * Rewrite the same with LINQ.
 * 
 */

namespace _05.OrderByThenBy
{
    using Students;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class OrderBy
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Гошо", "Гошев", 24));
            students.Add(new Student("Жоро", "Пешев", 34));
            students.Add(new Student("Тодор", "Стоянов", 14));
            students.Add(new Student("Иван", "Петров", 18));
            students.Add(new Student("Владимир", "Петров", 21));
            students.Add(new Student("Димитър", "Тодоров", 35));

            
            // lambda expression
            var sortDescendingStudentsLambda = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);

            foreach (var st in sortDescendingStudentsLambda)
            {
                Console.WriteLine(st.FirstName + " " +  st.LastName);
            }


            //Rewrite the same with LINQ.
            var sortDescendingStudentsLinq = from student in students
                                             orderby student.FirstName descending, student.LastName descending
                                             select student;

            Console.WriteLine("\nSame sort with Linq");
            foreach (var st in sortDescendingStudentsLinq)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }

        }
    }
}
