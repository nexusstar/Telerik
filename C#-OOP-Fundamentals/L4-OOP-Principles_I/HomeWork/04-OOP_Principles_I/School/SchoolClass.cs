namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class SchoolClass : ICommentable
    {
        private List<Student> classStudents;
        private List<Teacher> classTeachers;
        private string classID;
        private string comment;

        public SchoolClass(List<Student> students, List<Teacher> teachers, string classID)
        {
            this.ClassStudents = students;
            this.ClassTeachers = teachers;
            this.ClassID = classID;

        }
        public SchoolClass(List<Student> students, List<Teacher> teachers, string classID, string comment)
        {
            this.Comment = comment;
        }

        public string ClassID
        {
            get
            {
                return this.classID;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Class identifier could not be empty");
                }
                this.classID = value;
            }

        }

        public List<Student> ClassStudents
        {
            get
            {
                return new List<Student>(this.ClassStudents);
            }
            set
            {
                this.classStudents = value;
            }
        }

        public List<Teacher> ClassTeachers
        {
            get
            {
                return new List<Teacher>(this.classTeachers);
            }
            set
            {
                this.classTeachers = value;
            }
        }
        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
        public void AddStudentToClass(Student student)
        {
            if (this.classStudents.Contains(student))
            {
                throw new ArgumentException("Student is already added in this class");
            }
            this.classStudents.Add(student);

        }

        public void AddTeacherToClass(Teacher teacher)
        {
            if (this.classTeachers.Contains(teacher))
            {
                throw new ArgumentException("Teacher is already added to this class");
            }
            this.classTeachers.Add(teacher);
        }

        public void AddComment(string comment)
        {
            if (string.IsNullOrEmpty(this.comment))
            {
               this.comment = comment;
            }
            else{

                this.comment  += "Update: " + comment;
                
            }
        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine("# Class ID: " + this.classID);
            if (!string.IsNullOrEmpty(this.comment))
                info.Append("Comment: ").AppendLine(this.comment);
            info.AppendLine(new string('-', 40));
            info.AppendLine("# Teachers:");
            info.AppendLine(new string('-', 30));
            foreach (var t in this.classTeachers)
            {
                info.AppendLine(t.ToString());
            }
            info.AppendLine("# Students:");
            info.AppendLine(new string('-', 30));
            foreach (var s in this.classStudents)
            {
                info.AppendLine(s.ToString());
            }

            return info.ToString();
        }
    }

}
