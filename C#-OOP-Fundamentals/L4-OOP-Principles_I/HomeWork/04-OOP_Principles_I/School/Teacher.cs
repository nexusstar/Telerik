using System.Collections.Generic;
using System.Text;
namespace School
{
    public class Teacher : People, ICommentable
    {
        private List<Discipline> disciplines;
        

        public Teacher(string name, List<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines;
        }

        public Teacher(string name, string comment, List<Discipline> disciplines)
            : base(name, comment)
        {
            this.Disciplines = disciplines;
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(this.disciplines);
                
            }
            set
            {
                this.disciplines = value;
            }
        }
       
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Teacher ").AppendLine (base.ToString());
            info.AppendLine("Disciplines:");
            info.AppendLine(new string('-', 25));
            foreach (var d in this.disciplines)
            {
                info.AppendFormat("{0}", d.ToString());
                info.AppendLine();
            }

            return info.ToString();
        }
    }
}
