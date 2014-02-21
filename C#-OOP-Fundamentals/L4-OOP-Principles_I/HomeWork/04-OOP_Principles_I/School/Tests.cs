namespace School
{
    using System;
    using System.Collections.Generic;

    class Tests
    {
        static void Main()
        {
            List<Student> students = new List<Student>() { 
            new Student("Ivan Petrov", "Needed more motivation"),
            new Student("Dragan Ivanov"),
            new Student("Gosho Peshev")
            };

            List<Discipline> disciplines= new List<Discipline>(){

                new Discipline("Mathematics", 3, 20, "More Lectures Needed"),
                new Discipline("Chemistry", 2, 10),
                new Discipline("Informatics", 1, 30)

            };

            List<Teacher> teachers = new List<Teacher>{
                new Teacher("Mento Menteshev","Please review load", disciplines),
                new Teacher("Tconio Bonev", disciplines),
                new Teacher("Stoino Koinov", disciplines)
            };

            SchoolClass firstA = new SchoolClass(students, teachers, "firstA");

            Console.WriteLine(firstA);
        }
    }
}
