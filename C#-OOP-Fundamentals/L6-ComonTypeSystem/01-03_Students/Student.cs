using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _01_03_Students
{
    public class Student : Person, ICloneable, IComparable //Icomparable in Person class compares them 1 by names and 2 by SSN
    {
        private string adress;
        private string mobilePhone;
        private string email;
        private string course;
        private Speciality speciality;
        private Faculty faculty;
        private University university;

        public Student(string firstName, string middleName, string familyName, string ssn,
            Speciality speciality, Faculty faculty, University university) //every person to be a student must have this
            : base(firstName, middleName, familyName, ssn)
        {
            this.Speciality = speciality;
            this.Faculty = faculty;
            this.University = university;
        }

        public Student(string firstName, string middleName, string familyName, string ssn, Speciality speciality, Faculty faculty, University university,
           string course, string addres, string email)
            : this(firstName, middleName, familyName, ssn, speciality, faculty, university)
        {
            this.Course = course;
            this.Adress = addres;
            this.Email = email;

        }

        public string Adress
        {
            get
            {
                return this.adress;
            }
            set
            {
                this.adress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                this.mobilePhone = value;
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
                if (value != null)
                {
                    if (Regex.IsMatch(value, @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", RegexOptions.IgnoreCase)) //this throws exception if value is null
                    {
                        this.email = value;
                    }
                    else
                    {
                        throw new ArgumentException("Email is unexpected format!");
                    }

                }
                this.email = value;

            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }
            set
            {

                this.course = value;
            }
        }

        public Speciality Speciality
        {
            get
            {
                return this.speciality;
            }
            set
            {
                if (!Enum.IsDefined(typeof(Speciality), value))
                {
                    throw new ArgumentException("This specialiry is not present!");
                }

                this.speciality = value;
            }
        }

        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }
            set
            {
                if (!Enum.IsDefined(typeof(Faculty), value))
                {
                    throw new ArgumentException("There is no such faculty!");
                }
                this.faculty = value;
            }
        }

        public University University
        {
            get
            {
                return this.university;
            }
            set
            {
                if (!Enum.IsDefined(typeof(University), value))
                {
                    throw new ArgumentException("There is no such university!");
                }
                this.university = value;
            }
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.FamilyName, this.SSN,
                this.Speciality, this.Faculty, this.University,
                this.Course, this.Adress, this.Email);
        }

        public override bool Equals(object obj)
        {

            Student other = obj as Student;

            if ((object)other == null) //- справка лекцията на Наков https://www.youtube.com/watch?feature=player_detailpage&v=j0odWkL_Rds#t=2775
                return false;

            if (!this.FirstName.Equals(other.FirstName))
                return false;

            if (!this.MiddleName.Equals(other.MiddleName))
                return false;

            if (!this.FamilyName.Equals(other.FamilyName))
                return false;

            if (!this.SSN.Equals(other.SSN))
                return false;

            return true;
        }

        public static bool operator ==(Student first, Student second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Student first, Student second)
        {
            if (!first.Equals(second))
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.FamilyName.GetHashCode();
        }


        // add spaces in enum PascalCase => Pascal Case
        public static string ToFriendlyCase(string EnumString)
        {
            return Regex.Replace(EnumString, "(?!^)([A-Z])", " $1");
        }

        public override string ToString()
        {
            string studentCourse = (this.Course == null)? "No courses yet": this.Course;
            string studentAdress = this.Adress ==null ? "No entry for adress": this.Adress;
            string studentEmail = this.Email == null? "No email entry": this.Email;
            StringBuilder st = new StringBuilder();
            st.AppendLine(base.ToString());
            st.AppendFormat("University: {0}", ToFriendlyCase(this.University.ToString())).AppendLine();
            st.AppendFormat("Speciality: {0}", ToFriendlyCase(this.Speciality.ToString())).AppendLine();
            st.AppendFormat("Faculty: {0}", ToFriendlyCase(this.Faculty.ToString())).AppendLine();
            st.AppendFormat("Course: {0}",studentCourse).AppendLine();
            st.AppendFormat("Adress: {0}", studentAdress).AppendLine();
            st.AppendFormat("Email: {0}", studentEmail).AppendLine();

            return st.ToString();

        }






    }

}
