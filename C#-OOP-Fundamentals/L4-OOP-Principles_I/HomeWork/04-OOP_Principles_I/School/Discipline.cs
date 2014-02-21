using System.Text;
namespace School
{
    public class Discipline : ICommentable
    {
        private string topic;
        private int numberOfLectures;
        private int numberOfExcercieses;
        private string comment;


        public Discipline(string topic, int numberOfLectures, int numberOfExcercises)
        {
            this.Topic = topic;
            this.NumberOfExcercieses = numberOfExcercises;
            this.NumberOfLectures = numberOfLectures;
        }

        public Discipline(string topic, int numberOfLectures, int numberOfExcercises, string comment)
            : this(topic, numberOfLectures, numberOfExcercises)
        {
            this.Comment = comment;
        }

        public string Topic
        {
            get
            {
                return this.topic;
            }
            set
            {
                this.topic = value;
            }
        }
        public int NumberOfLectures
        {
            get
            {

                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }
        public int NumberOfExcercieses
        {
            get
            {
                return this.numberOfExcercieses;
            }
            set
            {

                this.numberOfExcercieses = value;
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

        public void AddComment(string comment)
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

            info.AppendLine(this.Topic);
            info.AppendLine(new string('-', 20));
            if (!string.IsNullOrEmpty(this.comment))
                info.Append("Comment: ").AppendLine(this.comment);

            info.Append(" Num of Lec.: ")
                .Append(this.numberOfLectures)
                .Append("  Num of Excs.: ")
                .Append(this.numberOfExcercieses).AppendLine();

            return info.ToString();

        }
    }
}
