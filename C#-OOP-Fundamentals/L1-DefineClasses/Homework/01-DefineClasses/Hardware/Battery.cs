namespace MobilePhone.Hardware
{
    using System;
    using System.Text;
    class Battery
    {
        //Battery types enumerator
        public enum BatteryTypes
        {
            LiPoly, LiIon, NiCd, NiMH

        }

        //Battery characteristics fields
        private string model; //only model is mandatory
        private uint? hoursIdle;
        private uint? hoursTalk;
        private BatteryTypes? batteryType;

        //define empty Battery Constructor
        public Battery()
            : this(null, null, null, null)
        {

        }

        //define constructor with input
        public Battery(string model, uint? hoursIdle, uint? hoursTalk, BatteryTypes? batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;

        }

        public BatteryTypes? BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                switch (value) //check if batteryType is one of predefinded 
                {
                    case null:
                    case BatteryTypes.LiIon:
                    case BatteryTypes.LiPoly:
                    case BatteryTypes.NiCd:
                    case BatteryTypes.NiMH:
                        this.batteryType = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("This is not a valid battery type!");
                }
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Model can not be empty");
                }

                this.model = value;
            }
        }
        public uint? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idle hours can not be negative!");
                }

                this.hoursIdle = value;
            }
        }

        public uint? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours talk can not be negative!");
                }
                this.hoursTalk = value;
            }
        }

        //overider ToString() method with collection of all data from class
        public override string ToString()
        {
            StringBuilder batteryData = new StringBuilder();

            batteryData.Append("Battery model: ").Append(this.Model).AppendLine();
            batteryData.Append("Hours Idle: ").Append(this.HoursIdle).AppendLine();
            batteryData.Append("Hours Talk: ").Append(this.HoursTalk).AppendLine();
            batteryData.Append("Battery type: ").Append(this.BatteryType).AppendLine();

            return batteryData.ToString();
        }
    }
}
