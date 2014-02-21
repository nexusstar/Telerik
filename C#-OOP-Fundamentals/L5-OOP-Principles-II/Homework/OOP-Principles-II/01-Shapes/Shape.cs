
namespace _01_Shapes
{
    using System.Text;
    public abstract class Shape
    {
        private decimal width;
        private decimal height;

        public Shape(decimal width, decimal height)
        {
            this.Width = width;
            this.Height = height;
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                this.width = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public abstract decimal CalculateSurface();

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Type:").AppendLine(this.GetType().Name);
            info.Append("Surface: ").AppendFormat("{0:#,##}", this.CalculateSurface().ToString());

            return info.ToString();
        }
    }
}
