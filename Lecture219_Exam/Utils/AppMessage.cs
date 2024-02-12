using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Lecture219_Exam.Utils
{
    internal static class AppMessage
    {
        public static void Display(string text, ErrCode code = ErrCode.OK, bool hold = false)
        {
            Console.Clear();
            switch (code)
            {
                case ErrCode.OK:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case ErrCode.Information:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case ErrCode.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case ErrCode.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case ErrCode.Fatal:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
            }
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
            if (hold)
            {
                Console.ReadLine();
            }
        }
    }
}
