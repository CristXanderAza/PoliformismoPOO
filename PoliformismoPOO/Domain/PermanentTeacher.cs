using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliformismoPOO.Domain
{
    public class PermanentTeacher : PermanentEmpleoyee
    {
        public string Carrer {  get; set; }

        public PermanentTeacher(string firstName, string lastName, string phone,
            decimal salary, string carrer) : base(firstName, lastName, phone, salary)
        {
            Carrer = carrer;
        }


        public override string ToString()
            => $"{base.ToString()}, Teacher of {Carrer}";
    }
}
