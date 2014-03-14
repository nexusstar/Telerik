namespace _01_03_Students
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public abstract class Person : IComparable
    {
        private string firstName;
        private string middleName;
        private string familyName;
        private string ssn;

        public Person(string firstName, string middleName, string familyName, string ssn)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.FamilyName = familyName;
            this.SSN = ssn;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First Name can not be null or empty!");
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Middle Name can not be null or empty!");
                }
                this.middleName = value;
            }
        }

        public string FamilyName
        {
            get
            {
                return this.familyName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Family Name can not be null or empty!");
                }
                this.familyName = value;
            }
        }

        public string SSN
        {
            get
            {
                return this.ssn;
            }
            private set
            {
                if (Regex.IsMatch(value, @"^^\d{3}-\d{2}-\d{4}$"))
                {
                    this.ssn = value;
                }
                else
                {
                    throw new ArgumentException("SSN number must be of 9 digits in format XXX-XX-XXXX");
                }

            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Name: {0} {1} {2}, SSN: {3}", this.FirstName, this.MiddleName, this.FamilyName, this.SSN);
            return str.ToString();
        }

        public int CompareTo(Object obj)
        {
            if (obj == null)
                return 1;

            Person other = obj as Person;
            if (other == null)
                throw new ArgumentException("Object is not a Person");

            int CompareValue = 0;
            CompareValue = this.FirstName.CompareTo(other.FirstName);

            if (CompareValue == 0)
            {
                CompareValue = this.MiddleName.CompareTo(other.MiddleName);

                if (CompareValue == 0)
                {
                    CompareValue = this.FamilyName.CompareTo(other.FamilyName);
                    if (CompareValue == 0)
                    {
                        CompareValue = this.SSN.CompareTo(other.SSN);
                    }
                }
            }
            return CompareValue;
        }
        
    }
}

