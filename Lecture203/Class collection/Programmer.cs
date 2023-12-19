using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture203.Class_collection
{
    internal class Programmer : Employee
    {
        public Programmer(string name, string surname, int salary, string programmingLanguage) : base(name, surname, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public string ProgrammingLanguage { get; set; }

        public override string EmployeeData()
        {
            return base.EmployeeData() + $", Language: {ProgrammingLanguage}";
        }
    }
}
