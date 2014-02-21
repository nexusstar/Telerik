namespace _03_04.FirstNameBeforeLast
{
    using Students;
    using System;
    using System.Linq;

    public class FirstBeforeLast
    {
        public static void Main()
        {
            Student[] learners = new Student[10];

            learners[0] = new Student("Tiana", "Feldman", 18);
            learners[1] = new Student("Irene", "Ditmore", 20);
            learners[2] = new Student("Dorinda", "Maurin");
            learners[3] = new Student("Christian", "Jolley", 24);
            learners[4] = new Student("Tara", "Stickles", 25);
            learners[5] = new Student("Kathleen", "Pinney", 20);
            learners[6] = new Student("Mariam", "Latham", 10);
            learners[7] = new Student("Rebbeca", "Xie", 5);
            learners[8] = new Student("Vanita", "Leaks", 6);
            learners[9] = new Student("Judie", "Arch", 22);


            var firstBeforeLast =
                from st in learners
                group st by st.FirstName.CompareTo(st.LastName) > 0 into g
                select new { Category = g.Key, Name = g };

            //show only the group we search
            Console.WriteLine("All students with FirstName before LastName");
            foreach (var g in firstBeforeLast)
            {
                if (g.Category == false)
                {
                    foreach (var st in g.Name)
                    {
                        Console.WriteLine(st.FirstName + " " + st.LastName);
                    }
                }
            }

            //show all groups from comparison
            foreach (var g in firstBeforeLast)
            {
                string compare = (g.Category ? " is after its " : " is before its ");

                Console.WriteLine("\nFirst name" + compare + "Last Name");

                foreach (var st in g.Name)
                {
                    Console.WriteLine(st.FirstName + " " + st.LastName);
                }
            }

            //find students with age between 18 and 24
            var ageTeenLegal =
                from st in learners
                where st.Age >= 18 && st.Age <= 24
                select new{st.FirstName, st.LastName, st.Age};
            Console.WriteLine("\nStudents with age between 18 and 24:");
            foreach (var st in ageTeenLegal)
            {
                Console.WriteLine("{0} {1}, {2}", st.FirstName, st.LastName, st.Age);
            }
            
            
        }

    }
}
