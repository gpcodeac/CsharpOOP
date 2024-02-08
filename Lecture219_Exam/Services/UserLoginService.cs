using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Repositories;
using Lecture219_Exam.Repositories.Interfaces;
using Lecture219_Exam.Services.Interfaces;

namespace Lecture219_Exam.Services
{
    internal class UserLoginService : IUserLoginService
    {
        //validate password, transfer to home screen or return true to page navigation service

        private readonly IEmployeeRepository _employeeRepository;

        public UserLoginService()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public bool ValidCredentials(string id, string password)
        {
            if (!int.TryParse(id, out int employeeId))
            {
                return false;
            }
            if (string.IsNullOrEmpty(password) || password != _employeeRepository.GetEmployee(employeeId).Password)
            {
                return false;
            }
            return true;
        }
    }
}
