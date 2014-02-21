namespace School
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private List<SchoolClass> classes;

        public School(List<SchoolClass> classes)
        {
            this.Classes = classes;
        }

        public List<SchoolClass> Classes
        {
            get
            {
                return new List<SchoolClass>(this.classes);
            }
            set
            {
                this.classes = value;
            }
        }

        public void AddClass(SchoolClass c)
        {
            this.classes.Add(c);
        }

        public void RemoveClass(SchoolClass c)
        {
            this.classes.Remove(c);
        }

    }
}
