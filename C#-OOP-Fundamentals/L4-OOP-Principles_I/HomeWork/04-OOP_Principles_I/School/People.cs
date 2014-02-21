namespace School
{
    using System;
    using System.Text;

    public abstract class People: ICommentable
    {
        private string name;
        private  string comment;

        public People(string name)
        {
            this.Name = name;
        }
        public People(string name, string comment)
            : this(name)
        {
            this.Comment = comment;
        }
       
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name could not be empty!");
                }
                this.name = value;
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

        public virtual void AddComment(string comment)
        {
            if (string.IsNullOrEmpty(this.comment))
            {
                this.comment = comment;
            }
            else
            {

                this.comment += "Update: " + comment;              
            }
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder(); 
            info.AppendLine(String.Format("Name: {0}", this.name));
            if (!string.IsNullOrEmpty(this.comment))
                info.Append("Comment: ").AppendLine(this.comment);
            return info.ToString();
        }
    }
}
