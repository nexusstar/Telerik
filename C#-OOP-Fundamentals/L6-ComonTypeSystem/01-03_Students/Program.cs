using System;
namespace _01_03_Students
{
    class Program
    {
        static void Main()
        {
            Student studentIvan = new Student("Ivan", "Ivanov", "Ivanov", "444-55-1234",
                Speciality.ArchitectureGeneral,Faculty.OmegaAlpha,University.AcademyCollege);
            Console.WriteLine(studentIvan);

            Student studentIvanTwo = new Student("Ivan", "Ivanov", "Ivanov", "444-55-1235", 
                Speciality.ArchitectureGeneral,Faculty.OmegaAlpha,University.AcademyCollege);
            Student studentIvanThree = new Student("Ivan", "Ivanov", "Petrov", "444-55-1236",
                Speciality.ComputerSciencesAndRelatedStudies, Faculty.ZetaTeta, University.SofiaUniversity);

            // compare students
            Console.WriteLine(studentIvan == studentIvanTwo); //False
     
            Console.WriteLine(studentIvan.Equals(studentIvanTwo)); //False

            Console.WriteLine(studentIvan != studentIvanTwo); //True

            Console.WriteLine(studentIvan.Equals(studentIvanThree)); //False

            // clone student
            var clone = studentIvan.Clone();


            // compare with cloned student
            Console.WriteLine("Are clone equal to original: {0}",studentIvan.Equals(clone));

            //studentIvan and clone are equal as their Names and SSN are the same 
            //see: http://msdn.microsoft.com/en-us/library/bsc2ak47%28v=vs.110%29.aspx
 
            //The following example uses ReferenceEquals to determine if two objects are the same instance.
            Console.WriteLine("Instance test: {0}", Object.ReferenceEquals(studentIvan, clone));
        }
    }
}
