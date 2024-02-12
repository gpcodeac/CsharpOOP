using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Lecture219_Exam.Repositories.Interfaces;
using Lecture219_Exam.Models;
using System.Text.Json;

namespace Lecture219_Exam.Repositories
{
    internal class EmployeeRepository : IEmployeeRepository
    {

        private readonly List<Employee> _employees = new();

        public EmployeeRepository()
        {
            //var employees = File.ReadAllLines(@"../../../Data/Employees.txt");
            //foreach (string employee in employees)
            //{
            //    string[] parts = employee.Split(',');
            //    int id = int.Parse(parts[0]);
            //    string password = parts[1];
            //    string name = parts[2];
            //    _employees.Add(new Employee() { Id = id, Name = name, Password = password });
            //}

            var jsonemployees = File.ReadAllText(@"../../../Data/Employees.json");
            _employees = JsonSerializer.Deserialize<List<Employee>>(jsonemployees);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employees;
        }

        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
            Save();
        }

        public void UpdateEmployee(Employee employee)
        {
            var ix = _employees.FindIndex(e => e.Id == employee.Id);
            if (ix != -1)
            {
                _employees[ix] = employee;
            }
            Save();
        }

        public void DeleteEmployee(int id)
        {
            _employees.Remove(_employees.FirstOrDefault(e => e.Id == id));
            Save();
        }

        private void Save()
        {
            var jsonemployees = JsonSerializer.Serialize(_employees);
            File.WriteAllText(@"../../../Data/Employees.json", jsonemployees);
        }

    }
}
