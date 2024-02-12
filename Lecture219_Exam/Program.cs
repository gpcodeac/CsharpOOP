using Lecture219_Exam.Services;
using Lecture219_Exam.Services.Interfaces;

namespace Lecture219_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
            while(true)
            {
                PageNavigationService pageNavigationService = new PageNavigationService();
                pageNavigationService.Run();
            }
        }

        

    }
}