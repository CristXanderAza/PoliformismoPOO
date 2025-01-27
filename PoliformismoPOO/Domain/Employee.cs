using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliformismoPOO.Domain
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public bool IsObtiveCompleted { get; set; }

        protected Employee(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public abstract decimal CalculateSalary();

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
