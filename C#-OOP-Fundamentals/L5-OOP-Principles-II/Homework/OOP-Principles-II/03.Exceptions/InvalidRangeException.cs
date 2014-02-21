namespace _03.Exceptions
{
    using System;
    using System.Collections.Generic;

    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(string msg):
            base(msg)
        {

        }

        public InvalidRangeException(string msg, Exception innerEx):base(msg,innerEx)
        {

        }
        public InvalidRangeException(string msg, T start, T end)
            : base(msg)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string msg, Exception innerEx, T start, T end)
            : base(msg, innerEx)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start
        {
            get { return this.start; }
            private set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }
            private set { this.end = value; }
        }
    }
}
