namespace _02.HumanStudentWorker
{
    class Student:Human
    {
        private char grade;

        public Student(string firstName, string lastName, char grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public char Grade
        {
            get
            {
                return this.grade;
            }
            protected set
            {
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Student {0} with grade: {1}", base.ToString(), this.grade);
        }
    }
}
