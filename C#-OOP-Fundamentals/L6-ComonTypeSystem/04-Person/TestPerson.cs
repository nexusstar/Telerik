namespace _04_Person
{
    using System;
    class TestPerson
    {
        static void Main()
        {
            Person gosho = new Person("Gosho", 25);
            Person pesho = new Person("Pesho");

            Console.WriteLine(gosho);
            Console.WriteLine(pesho);
        }
    }
}
