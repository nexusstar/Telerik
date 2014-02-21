namespace _18_19.GroupStudents
{
    using System.Collections.Generic;
    using System.Linq;

    public static class StudentsExtensions
    {
        public static Student[] OrderByGroupName(this IEnumerable<Student> listOfStudents)
        {
            return listOfStudents.OrderBy(x => x.GroupName).ToArray();
        }
    }
}
