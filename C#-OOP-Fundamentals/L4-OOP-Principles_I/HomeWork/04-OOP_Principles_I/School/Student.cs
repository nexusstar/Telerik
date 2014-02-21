namespace School
{
    using System;
    using System.Text;
    public class Student : People, ICommentable
    {
        private readonly int classNumber;
        private static int lastUsedClassNumber;
       

        static Student()
        {
            lastUsedClassNumber = 0;
        }

        public Student(string name):base(name)
        {
            lastUsedClassNumber++;
            this.classNumber = lastUsedClassNumber;
        }
        public Student(string name, string comment)
            : base(name, comment)
        {
            lastUsedClassNumber++;
            this.classNumber = lastUsedClassNumber;
        }

        private int ClassNumber
        {
            get
            {
                return this.classNumber;
            }     
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append(base.ToString());
            info.AppendLine(string.Format("ClassNumber: {0}", this.classNumber));
            return info.ToString();
        }
    }
}
