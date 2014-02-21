namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AnimalTests
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Cat("Jane", 1.6, Sex.Male),
                new Tomcat("Sam", 1.5),
                new Kitten("Juan", 4),
                new Dog("Sharo", 3, Sex.Male),
                new Frog("LeepLeg", 2, Sex.Female)
            };

            List<Cat> cats = new List<Cat>
            {
                new Cat("Shiny", 0.5, Sex.Male),
                new Cat("Bell", 0.5, Sex.Male),
                new Kitten("Dixie", 2),
                new Tomcat("Tom", 5)
            };

            Console.WriteLine("Animals:");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("Cats:");
            foreach (Cat cat in cats)
            {
                Console.WriteLine(cat);
            }

            Console.WriteLine("Animals average age");
            Console.WriteLine(animals.Average(animal => animal.Age));

            Console.WriteLine("Cats average age");
            Console.WriteLine(cats.Average(cat => cat.Age));
        }
    }
}
