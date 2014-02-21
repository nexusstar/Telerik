
namespace _02.HumanStudentWorker
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private const int defaultWorkDaysInWeek = 5;

        private decimal weekSalary;
        private decimal woorkHoursPerDay;
        private int workDaysInWeek;

        public Worker(string firstName, string lastName)
            : base(firstName, lastName)
        {

        }

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay,
            int workDaysInWeek = defaultWorkDaysInWeek)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.WorkDaysInWeek = workDaysInWeek;
        }


        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.woorkHoursPerDay;
            }
            private set
            {
                this.woorkHoursPerDay = value;
            }
        }

        public int WorkDaysInWeek
        {
            get { return this.workDaysInWeek; }
            private set
            {
                this.workDaysInWeek = value;
            }
        }

        public decimal GetMonneyPerHour()
        {
            return this.weekSalary / this.workDaysInWeek / this.woorkHoursPerDay;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat("Worker {0}", base.ToString()).AppendLine();
            info.AppendLine("Week Salary: " + this.weekSalary);
            info.AppendLine("Work hours/day: " + this.woorkHoursPerDay);
            info.AppendFormat("Money per hour: {0:F2}", GetMonneyPerHour()).AppendLine();

            return info.ToString();
        }
    }
}
