namespace _01_Shapes
{
    using System;
    using System.Text;
    class Triangle : Shape
    {
        public Triangle(decimal width, decimal height)
            : base(width, height)
        { }

        public override decimal CalculateSurface()
        {
            return (this.Width * this.Height) / 2;
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
