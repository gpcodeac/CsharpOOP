using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Repositories.Interfaces;
using Lecture219_Exam.Models;

namespace Lecture219_Exam.Repositories
{
    internal class EmployeeRepository : IEmployeeRepository
    {

        private readonly List<Employee> _employees = new();

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
        }

        public void UpdateEmployee(Employee employee)
        {
            var ix = _employees.FindIndex(e => e.Id == employee.Id);
            if (ix != -1)
            {
                _employees[ix] = employee;
            }
        }

        public void DeleteEmployee(int id)
        {
            _employees.Remove(_employees.FirstOrDefault(e => e.Id == id));
        }

    }
}
