using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliformismoPOO.Domain
{
    public class AdministrativeEmployee : PermanentEmpleoyee
    {
        public string Department {  get; set; }

        public AdministrativeEmployee(string firstName, string lastName, string phone, decimal salary, string department)
            : base(firstName, lastName, phone, salary)
        {
            Department = department;
        }



        public override string ToString()
            => $"{base.ToString()}, admin of {Department}";

    }
}
