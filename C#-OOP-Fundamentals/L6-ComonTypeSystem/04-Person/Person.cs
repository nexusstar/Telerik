namespace _04_Person
{
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private int? age;
        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name, int? age)
            :this(name)
        {
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name must not be empty!");
                }
                this.name = value;
            }
        }
        public int? Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive value");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder person = new StringBuilder();
            string ageOfPerson = (this.Age == null) ? "n/a" : this.Age.ToString();
            person.AppendFormat("Name: {0} ", this.Name);
            person.AppendFormat("Age: {0}", ageOfPerson);

            return person.ToString();
        }
    }
}
