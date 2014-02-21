namespace _01_Shapes
{
    using System;
    using System.Text;
    public class Rectangle:Shape
    {
        public Rectangle(decimal width, decimal height)
            : base(width, height)
        { }

        public override decimal CalculateSurface()
        {
            return this.Width * this.Height;
        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(base.ToString());
            info.Append("Width:   ").AppendLine(this.Width.ToString());
            info.Append("Height:  ").AppendLine(this.Height.ToString());

            return info.ToString();

        }
    }
}
