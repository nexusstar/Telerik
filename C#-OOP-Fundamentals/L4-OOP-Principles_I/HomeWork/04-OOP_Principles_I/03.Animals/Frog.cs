namespace _03.Animals
{
    public class Frog : Animal
    {
        public Frog(string name, double age, Sex sex)
            : base(name, age, sex)
        {
        }

        public override string ProduceSound()
        {
            return "Kvak";
        }
    }
}