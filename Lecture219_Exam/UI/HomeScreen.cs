using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture219_Exam.Models;
using Lecture219_Exam.UI.Interfaces;
using Lecture219_Exam.Utils;

namespace Lecture219_Exam.UI
{
    internal class HomeScreen : IScreen
    {
        public IScreen Print()
        {
            while (true)
            {
                string text = """
                Welcome to the Home Screen!


                Choose what you want to do:

                1. Create a new order
                2. Change an existing order
                3. Close an order

                0. Exit

                """;
                AppMessage.Display(text);

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        return new CreateOrderScreen();
                    case "2":
                        return new ChangeOrderScreen();
                    case "3":
                        return new CloseOrderScreen();
                    case "0":
                        return new LoginScreen();
                    default:
                        AppMessage.Display("Invalid choice. Please try again.", ErrCode.Warning, true);
                        break;
                }
            }
        }
    }
}
