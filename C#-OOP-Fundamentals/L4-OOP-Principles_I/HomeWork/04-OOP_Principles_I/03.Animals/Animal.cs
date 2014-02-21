namespace _03.Animals
{
    using System;
    using System.Text;

    public abstract class Animal : ISound
    {
        private string name;
        private double age;
        private Sex sex;

        public Animal(string name, double age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public double Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public Sex Sex
        {
            get
            {
                return this.sex;
            }
            private set
            {
                this.sex = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.Append("Type: ").Append(this.GetType().Name).AppendLine();
            info.Append("Name: ").Append(this.Name).AppendLine();
            info.Append("Age: ").Append(this.Age).AppendLine();
            info.Append("Sex: ").Append(this.Sex).AppendLine();
            info.Append("Sound: ").Append(this.ProduceSound()).AppendLine();

            return info.ToString();
        }
    }
}
