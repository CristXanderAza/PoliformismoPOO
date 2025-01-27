using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PoliformismoPOO.Domain
{
    public class TeacherPerHour : Employee
    {
        public decimal Fee { get; set; }
        public int HoursWorked {  get; set; }
        public string Subject { get; set; }

        public TeacherPerHour(string firstName, string lastName, string phone, string subject) : base(firstName, lastName, phone)
        {
            HoursWorked = 800;
            Subject = subject;
        }

        public TeacherPerHour(string firstName, string lastName, string phone, string subject, int hours) : base(firstName, lastName, phone)
        {
            Fee = 800;
            HoursWorked = hours;
            Subject = subject;
        }

        public override decimal CalculateSalary()
            => Fee * HoursWorked;

        public override string ToString()
          => $"{base.ToString()}, temporal teacher of subject: {Subject}";

    }
}
