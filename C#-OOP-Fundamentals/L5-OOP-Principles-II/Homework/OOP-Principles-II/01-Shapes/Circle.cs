namespace _01_Shapes
{
    using System;
    using System.Text;
    public class Circle : Shape
    {
        public Circle(decimal radius) :
            base(radius, radius) { }

        
        public override decimal CalculateSurface()
        {
            return (decimal)Math.PI * this.Height * this.Width / 4m;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(base.ToString());
            info.Append("Radius:  ").AppendLine(this.Width.ToString());
            
            return info.ToString();

        }
    }
}
