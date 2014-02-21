namespace _02.HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HumanTest
    {
        private static readonly Random random = new Random();

        private static string CreateFirstName()
        {
            string firstName = string.Empty;
            List<string> firstNames = new List<string>()
            {
                "Tim", "Dana", "Kathryn", "Elbert", "Eric", "Jonathon", "Shari", "Kenneth"
            };

            firstName = firstNames[random.Next(0, 8)];
            return firstName;
        }

        private static string CreateLastName()
        {

            string lastName = string.Empty;
            List<string> lastNames = new List<string>()
            {
                "Barker", "Mitchell", "Washington", "Leonard", "Duncan", "Haynes", "Sims", "Strickland"
            };

            lastName = lastNames[random.Next(0, 8)];
            return lastName;
        }

        private static char CreateGrade()
        {
            char grade;
            List<char> grades = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F' };
            grade = grades[random.Next(0, 6)];
            return grade;
        }

        private static Student CreateStudent()
        {
            string firstName = CreateFirstName();
            string lastName = CreateLastName();
            char grade = CreateGrade();
            Student student = new Student(firstName, lastName, grade);
            return student;
        }

        public static List<Student> CreateStudents(int numberOfStudents)
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = CreateStudent();
                students.Add(student);
            }

            return students;
        }

        private static Worker CreateWorker()
        {
            string firstName = CreateFirstName();
            string lastName = CreateLastName();
            decimal weekSalary = random.Next(200, 401);
            decimal workHoursPerDay = random.Next(8, 13);
            Worker worker = new Worker(firstName, lastName, weekSalary, workHoursPerDay);
            return worker;
        }

        public static List<Worker> CreateWorkers(int numberofWorkers)
        {
            List<Worker> workers = new List<Worker>();

            for (int i = 0; i < numberofWorkers; i++)
            {
                Worker worker = CreateWorker();
                workers.Add(worker);
            }

            return workers;
        }

    }
}
