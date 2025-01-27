using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliformismoPOO.Domain
{
    public abstract class PermanentEmpleoyee : Employee
    {
        public decimal Salary { get; set; }

        protected PermanentEmpleoyee(string firstName, string lastName, string phone, decimal salary) : base(firstName, lastName, phone)
        {
            Salary = salary;
        }

        public override decimal CalculateSalary()
            => (IsObtiveCompleted) ? Salary : (Salary / 2);

    }
}
