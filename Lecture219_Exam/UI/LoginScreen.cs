using Lecture219_Exam.Services;
using Lecture219_Exam.Services.Interfaces;
using Lecture219_Exam.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture219_Exam.UI
{
    internal class LoginScreen : IScreen
    {

        private IUserLoginService _userLoginService = new UserLoginService();

        public IScreen Print()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter your user Id: ");
                string id = Console.ReadLine();
                Console.WriteLine("Enter your password: ");
                string password = Console.ReadLine();
                if (_userLoginService.ValidCredentials(id, password))
                {
                    return new HomeScreen();
                }
                else
                {
                    Console.WriteLine("Invalid user Id or password. Please try again.");
                    Console.ReadKey();
                }
            }
        }

    }
}
