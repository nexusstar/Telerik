namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int? age;
        private string fn;
        private string tel;
        private string email;
        private List<int> marks;
        private int groupNumber;




        //Constructors
        public Student(string firstName, string lastName)  //default we need only firstName and lastName
            : this(firstName, lastName, null)
        {

            this.FirstName = firstName;
            this.LastName = lastName;

        }
        
        public Student(string firstName, string secondName, int? age)
        {
            this.FirstName = firstName;
            this.LastName = secondName;
            this.Age = age;
        }

        public Student(string firstName, string lastName, int? age, string fn, string tel, string email, int groupNum, params int[] inputMarks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = fn;
            this.Telephone = tel;
            this.Email = email;
            this.GroupNumber = groupNum;
            this.marks = new List<int>(inputMarks);
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("First name must be at least 2 characters");
                }
                this.firstName = value;
            }

        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Last name must be at least 2 characters");
                }

                this.lastName = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value != 0 && value < 0)
                {
                    throw new ArgumentException("Age must be positive value");
                }
                this.age = value;
            }
        }
        public string FacultyNumber
        {
            get
            {
                return this.fn;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Faculty number can not be null or empty !");
                }

                this.fn = value;
            }
        }

        public string Telephone
        {
            get
            {
                return this.tel;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Phone number can not be null or empty !");
                }

                this.tel = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email can not be null or empty !");
                }

                this.email = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value < 1)
                {
                    throw new ApplicationException("Group number must be > 0 !");
                }
                this.groupNumber = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return new List<int>(this.marks);
            }
        }

        public void AddMark(int currMark)
        {
            if (currMark < 1 || currMark > 6)
            {
                throw new ApplicationException("Marks are between 1 and 6 !");
            }
            this.marks.Add(currMark);
        }

        public void RemoveMarkAtPosition(int position)
        {
            if (position < 0 || position >= this.marks.Count)
            {
                throw new ApplicationException("No such position");
            }
            this.marks.RemoveAt(position);
        }

        public void RemoveMark(int currMark)
        {
            if (!this.marks.Contains(currMark))
            {
                throw new ApplicationException("No such mark");
            }
            this.marks.Remove(currMark);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            //using reflection to get all the properties by name and value
            var properties = this.GetType().GetProperties();
            result.AppendLine(new string('-', 40));
            result.AppendFormat("{0}: {1}", ("First Name").PadLeft(15), this.FirstName).AppendLine();
            result.AppendFormat("{0}: {1}", ("Last Name").PadLeft(15), this.LastName).AppendLine();
            result.AppendFormat("{0}: {1}", ("Age").PadLeft(15), this.Age).AppendLine();
            result.AppendFormat("{0}: {1}", ("Faculty N").PadLeft(15), this.FacultyNumber).AppendLine();
            result.AppendFormat("{0}: {1}", ("Telephone").PadLeft(15), this.Telephone).AppendLine();
            result.AppendFormat("{0}: {1}", ("Email").PadLeft(15), this.Email).AppendLine();
            result.AppendFormat("{0}: {1}", ("Group N").PadLeft(15), this.GroupNumber).AppendLine();

            result.Append("Marks: ".PadLeft(17));
            result.AppendFormat(string.Join(", ", this.Marks));
            return result.ToString();
        }
    }
}
