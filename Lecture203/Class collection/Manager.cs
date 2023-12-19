using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture203.Class_collection
{
    internal class Manager : Employee
    {
        public Manager() { }
        public Manager(string name, string surname, int salary, int bonus) : base(name, surname, salary)
        {
            Bonus = bonus;
        }

        public int Bonus { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Programmer> Programmers { get; set; } = new List<Programmer>();


        public override string EmployeeData()
        {
            return base.EmployeeData() + $", Bonus: {Bonus}, Number of employees: {Employees.Count()}";
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void AddProgrammer(Programmer programmer)
        {
            Programmers.Add(programmer);
        }

        public void PrintProgrammers()
        {
            foreach (var programmer in Programmers)
            {
                Console.WriteLine(programmer.EmployeeData());
            }
        }
    }
}
