using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Course_Project
{
    internal class Employee
    {
        public string EGN { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }

        public override string ToString()
        {
            return $"{EGN} {FirstName} {MiddleName} {LastName} {Profession} {Department} {Salary} {StartDate}";
        }
    }
}
