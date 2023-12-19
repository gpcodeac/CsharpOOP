using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture203.Class_collection
{
    internal class Employee
    {
        public Employee()
        {
        }
        public Employee(string name, string surname, int salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }

        
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }


        public virtual string EmployeeData()
        {
            return $"Name: {Name}, Surname: {Surname}, Salary: {Salary}";
        }
    }
}
