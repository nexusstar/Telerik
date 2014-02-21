namespace MobilePhone.Hardware
{
    using MobilePhone.CallManager;
    using System;
    using System.Collections.Generic;
    using System.Text;
      
    class GSM
    {
        //define GSM device fields
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;

        private Battery battery;
        private Display display;

        //hold a list of the performed calls
        private List<Call> callHistory = new List<Call>();

        //static field iPhone4s, display through property
        private static readonly GSM iPhone4s = new GSM("iPhone 4s", "Apple", 760, "Jhon Doe",
            new Display(640, 960, 3.5, 16000000),
            new Battery("Non-removable", null, null, Battery.BatteryTypes.LiIon)
            );

        //define GSM constructors
        public GSM(string model, string manufacturer)                               //default constructor 
            : this(model, manufacturer, null, null, new Display(), new Battery())
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        //full constructor
        public GSM(string model, string manufacturer, double? price, string owner, Display display, Battery battery)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Display = display;
            this.Battery = battery;
        }

        //Properties
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Model name could not be empty!");
                }
                else if (value.Length <= 1)
                {
                    throw new ArgumentException("Model name must be at least 2 characters long");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Manufacturer could not be empty!");
                }
                else if (value.Length <= 1)
                {
                    throw new ArgumentException("Manufacturer name must be at least 2 characters long");
                }

                this.manufacturer = value;
            }
        }
        public double? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value != null && value < 0)
                {
                    throw new ArgumentException("Price can not be negative!");
                }

                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value != null)
                {
                    if (value.Equals(string.Empty)) //Owner name could be null but not empty string
                    {
                        throw new ArgumentException("Owner name could not be empty");
                    }
                }

                this.owner = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public static GSM IPhone
        {
            get
            {
                return iPhone4s;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            protected set
            {
                this.callHistory = value;
            }
        }

        //Method to add call to CallHistory
        public void AddCall(string dialedNumber, ulong callDuration)
        {
            this.CallHistory.Add(
                new Call(DateTime.Now,dialedNumber,callDuration)
                );
        }

        /*
         * Methods to remove call from CallHistory
         * 
         * This is where the idea came from:
         * 1. http://bit.ly/1dmiopY
         * 
         * 2. http://bit.ly/1imSA2n
         * 
         */

        /// <summary>
        /// Removes all calls from Call History with specified Number
        /// </summary>
        /// <param name="dialedNumber">Number to remove history with</param>
        public void RemoveCall(string dialedNumber)
        {
            this.callHistory.RemoveAll(call => call.CalledNumber == dialedNumber);
        }

        /// <summary>
        /// Removes only calls with specified Number with specified callDuration
        /// note: remove all occurences of Number, Duration matches
        /// </summary>
        /// <param name="dialedNumber">Number to remove history with</param>
        /// <param name="callDurration">Duration of call in seconds</param>
        public void RemoveCall(string number, ulong duration)
        {
            this.callHistory.RemoveAll(call => call.CalledNumber == number && call.CallDuration == duration);
        }

        /// <summary>
        /// Removes Call from CallHistory
        /// </summary>
        /// <param name="call">Object Call to be removed</param>
        public void RemoveCall(Call call)
        {
            this.callHistory.Remove(call);
        }


        //Method to clear CallHistory
        public void ClearCallHistory() {
            this.callHistory.Clear();
        }

        public decimal CallculatePrice(decimal pricePerMinute)
        {
            //ammout of time after which we add another minute 
            ulong border = 30;


            ulong time = 0;
            foreach (Call item in this.callHistory)
            {
                time += item.CallDuration;
            }
            //get whole minutes;
            ulong minutes = time / 60;
            
            //remaining seconds
            ulong seconds = time - minutes * 60;
            
            //Add a minute if remaining is more than 30 seconds
            if (seconds >= border)
            {
                minutes++;
            }

            return minutes * pricePerMinute;
        }

        //Method override
        public override string ToString()
        {
            StringBuilder gsmData = new StringBuilder();
            gsmData.AppendLine().Append(new string('-', 5)).Append("GSM Info").Append(new string('-', 5)).AppendLine();
            gsmData.Append("Model: ").Append(this.Model).AppendLine();
            gsmData.Append("Manufacturer: ").Append(this.Manufacturer).AppendLine();
            gsmData.Append("Price: ").AppendFormat("{0:C}", this.Price).AppendLine();
            gsmData.Append("Owner: ").Append(this.Owner).AppendLine();
            gsmData.AppendLine().Append(new string('-', 5)).Append("Display").Append(new string('-', 5)).AppendLine();
            gsmData.Append(this.Display).AppendLine();
            gsmData.AppendLine().Append(new string('-', 5)).Append("Battery").Append(new string('-', 5)).AppendLine();
            gsmData.Append(this.Battery).AppendLine();

            return gsmData.ToString();

        }

    }
}
