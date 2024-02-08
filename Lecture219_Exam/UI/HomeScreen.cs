using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture219_Exam.UI
{
    internal static class HomeScreen
    {
        public static int Print()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Home Screen!\n\n");
                string options = """
                Choose what you want to do:

                1. Create a new order
                2. Change an existing order
                3. Close an order

                0. Exit

                """;
                Console.WriteLine(options);
                string choice = Console.ReadLine();
            }
        }
    }
}
