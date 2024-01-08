using Lecture210.Classes;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Lecture210
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo ch;
            while (true)
            {
                TaskOrchestrator();

                Console.Write("Press the Escape (Esc) key to quit\n\n\n");
                ch = Console.ReadKey();
                if (ch.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

        static void TaskOrchestrator()
        {
            Console.WriteLine("Choose the task number:");
            string taskNr = Console.ReadLine();
            switch (taskNr)
            {
                case "1.1":
                    Task1p1();
                    break;
                case "2.1":
                    Task2p1();
                    break;
                case "3.1":
                    Task3p1();
                    break;
                case "4.1":
                    Task4p1();
                    break;

                //case "000":
                //    Test0();
                //    break;
                default:
                    Console.WriteLine("No such task number.");
                    break;
            }
        }


        static void Task1p1()
        {

            try
            {
                string str = "12a";
                double num = Convert.ToDouble(str);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();


            try
            {
                TestClass tc = new TestClass("TC text", 123);
                double num = Convert.ToDouble(tc);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();


            try
            {
                string str = "314159265358979323846";
                int num = Convert.ToInt32(str);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();

        }


        static void Task2p1()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i <= arr.Length; i++)
            {
                try
                {
                    Console.WriteLine(arr[i]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.GetType().Name);
                    Console.WriteLine(e.Message);
                }
            }
            //Console.WriteLine(arr[7]);
        }

        static void Task3p1()
        {
            int[] arr = { 19, 0, 75, 52 };
            
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine(arr[i] / arr[i + 1]);
                try
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.GetType().Name} at index 'i' = {i} .");
                    //Console.WriteLine(e.Message);
                }
            }
        }

        static void Task4p1()
        {
            FileStream fs = File.Open("C:\\test.txt", FileMode.Open);
            FileStream fs2 = FileReader.OpenFile("D:\\test.txt");
        }
    }
}