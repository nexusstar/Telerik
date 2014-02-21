
namespace MobilePhone.CallManager
{
    using System;
    using System.Text;
    class Call
    {
        //define fields
        private DateTime callDateAndTime;
        private string calledNumber;
        private ulong callDuration;

        //define counstructors
        public Call(DateTime callDateAndTime, string calledNumber, ulong callDuration)
        {
            this.callDateAndTime = callDateAndTime;
            this.calledNumber = calledNumber;
            this.callDuration = callDuration;
        }

        //Properties
        public DateTime CallDateAndTime
        {
            get
            {
                return this.callDateAndTime;
            }
        }

        public string CalledNumber
        {
            get
            {
                return this.calledNumber;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Called number could not be less than 3 digits");
                }

                this.calledNumber = value;
            }
        }

        public ulong CallDuration
        {
            get
            {
                return this.callDuration;

            }
            set
            {
                this.callDuration = value;
            }
        }

        //Method override ToString();

        public override string ToString()
        {
            StringBuilder callData = new StringBuilder();

            callData.Append("Call Date: ").Append(this.callDateAndTime.ToShortDateString()).AppendLine();
            callData.Append("Called number: ").Append(this.calledNumber).AppendLine();
            callData.Append("Call duration: ").Append(this.callDuration / 60 + ":" + this.CallDuration % 60).AppendLine();

            return callData.ToString();
        }
    }
}
