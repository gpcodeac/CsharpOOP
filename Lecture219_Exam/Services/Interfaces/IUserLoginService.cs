using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture219_Exam.Services.Interfaces
{
    internal interface IUserLoginService
    {
        //validate password, transfer to home screen or return true to page navigation service
        public bool ValidCredentials(string username, string password);
    }
}
