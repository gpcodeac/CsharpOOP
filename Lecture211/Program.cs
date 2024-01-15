using Lecture211.Classes;
using System.Diagnostics;
using System.Text;

namespace Lecture211
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

                case "000":
                    Test0();
                    break;
                default:
                    Console.WriteLine("No such task number.");
                    break;
            }
        }


        static void Test0()
        {
            FileStream fs = File.Open("D:\\test.txt", FileMode.Open);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes);
            byte last = bytes[fs.Length - 1];
            //string text = Encoding.UTF8.GetString(bytes);
            char ch = (char)last;
            string str = ch.ToString();
            Console.WriteLine(str);
            int nullIndex = str.IndexOf('\0');
            Console.WriteLine(nullIndex.ToString());
            int nullIndex2 = Array.IndexOf(bytes, (byte)'\0');
            Console.WriteLine(nullIndex2.ToString());
            int nullIndex3 = Array.IndexOf(bytes, null);
            Console.WriteLine(nullIndex3.ToString());
            StreamReader sr = new StreamReader(fs);
            fs.Close();
        }

        static void Task1p1()
        {
            string name = "John";
            string dob = "1990";
            string domain = "gmail.com";
            string email = name.GenerateEmail(dob, domain);
            Console.WriteLine(email);
        }


        static void Task2p1()
        {
            int i = 5;
            int j = 7;
            bool result = i.GreaterThan(j);

            bool isPositive = Int32.IsPositive(i);
        }


        static void Task3p1()
        {
            int i = 5;
            string text = "This is a text";
            bool result = text.GTZero();
            Console.WriteLine(result);
        }


        static void Task4p1()
        {
            List<string> halflines = new();
            Stopwatch sw = new();


            sw.Start();
            var fi = new FileInfo("D:\\test.txt");
            halflines = fi.EveryOtherLineFI();
            sw.Stop();
            Console.WriteLine($"Time elapsed for file info: {sw.ElapsedTicks} ");
            sw.Reset();


            sw.Start();
            using (FileStream fs1 = File.Open("D:\\test.txt", FileMode.Open))
            {
                halflines = fs1.EveryOtherLineSR();
            }
            sw.Stop();
            Console.WriteLine($"Time elapsed for stream reader: {sw.ElapsedTicks} ");
            sw.Reset();


            sw.Start();
            using (FileStream fs2 = File.Open("D:\\test.txt", FileMode.Open))
            {
                halflines = fs2.EveryOtherLineSpan();
            }
            sw.Stop();
            Console.WriteLine($"Time elapsed for span: {sw.ElapsedTicks} ");
            sw.Reset();


            sw.Start();
            using (FileStream fs3 = File.Open("D:\\test.txt", FileMode.Open))
            {
                halflines = fs3.EveryOtherLineArr();
            }
            sw.Stop();
            Console.WriteLine($"Time elapsed for byte[]: {sw.ElapsedTicks} ");
            sw.Reset();


            //foreach (string line in halflines)
            //{
            //    Console.WriteLine(line);
            //}

        }
    }
}