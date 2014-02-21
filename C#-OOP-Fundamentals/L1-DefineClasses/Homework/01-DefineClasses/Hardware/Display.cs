namespace MobilePhone.Hardware
{
    using System;
    using System.Text;
    class Display
    {
        //Display characteristics fields
        private uint? height;
        private uint? width;
        private double? size;
        private long? colors;


        //Constructor without properties
        public Display() : this(null, null, null, null) { } //Fill all unknown data  with null

        //Constructor with input
        public Display(uint? width, uint? height, double? size, long? color)
        {
            this.Width = width;
            this.Height = height;
            this.Size = size;
            this.Colors = color;
        }

        //Properties
        public uint? Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value != null && value <= 0)
                {
                    throw new ArgumentException("Height can not be 0 or negative");
                }

                this.height = value;
            }
        }

        public uint? Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value != null && value <= 0)
                {
                    throw new ArgumentException("Width can not be 0 or negative");
                }

                this.width = value;
            }
        }

        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value != null && value <= 0)
                {
                    throw new ArgumentException("Size can not be 0 or negative");
                }

                this.size = value;
            }
        }
        public long? Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                if (value != null && value < 2)
                {
                    throw new ArgumentException("Numbers of colors must be at least 2");
                }

                this.colors = value;
            }
        }

        //override ToString() method with collection of all data from class
        public override string ToString()
        {
            StringBuilder displayData = new StringBuilder();

            displayData.Append("Height: ").Append(this.Height).AppendLine();
            displayData.Append("Width: ").Append(this.Width).AppendLine();
            displayData.Append("Size in inches: ").Append(this.Size).AppendLine();
            displayData.Append("Colors: ").Append(this.Colors).AppendLine();

            return displayData.ToString();
        }
    }
}
