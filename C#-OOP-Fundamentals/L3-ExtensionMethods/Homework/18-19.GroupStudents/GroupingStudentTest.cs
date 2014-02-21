namespace _18_19.GroupStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    

    public class GroupingStudentTest
    {
        public static void Main()
        {
            Student[] students = GenerateStudentArray();

            //Linq
            Console.WriteLine();
            Console.WriteLine("Linq : ");
            Console.WriteLine();

            var orderedStudentsLinq = from st in students
                                      orderby st.GroupName
                                      select st;

            foreach (var student in orderedStudentsLinq)
            {
                Console.WriteLine(student);
            }
            //extensionMethods
            Console.WriteLine();
            Console.WriteLine("Extension Methods : ");
            Console.WriteLine();

            var orderedStudentsExtension = students.OrderByGroupName();

            foreach (var student in orderedStudentsExtension)
            {
                Console.WriteLine(student);
            }
        }

        public static Student[] GenerateStudentArray()
        {
            string[] names = new string[] { "Sammy Coleman", "Sam Rice", "Oscar	Douglas", "Mitchell	Barnes", "Lloyd	Torres", "Randal Ball", "Gary Massey", "Bryan Bridges" };

            string[] groups = new string[] { "HTML", "PHP", "OOP", "C# part II", "C# part I" };

            Random rnd = new Random();

            Student[] students = new Student[rnd.Next(20, 31)];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student(names[rnd.Next(0, names.Length)], groups[rnd.Next(0, groups.Length)]);
            }

            return students;
        }
        

    }
}

