namespace Lecture214
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
                case "1.2":
                    Task1p2();
                    break;
                case "1.3":
                    Task1p3();
                    break;

                case "2.1":
                    Task2p1();
                    break;
                case "2.2":
                    Task2p2();
                    break;
                case "2.3":
                    Task2p3();
                    break;
                case "2.4":
                    Task2p4();
                    break;

                case "3.1":
                    Task3p1();
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
            Console.WriteLine("Test0");
            Func<int, int, int> f = (x, y) => x * y;
        }

        static void Task1p1()
        {
            Console.WriteLine("Task1p1");
        }

        static void Task1p2()
        {
            Console.WriteLine("Task1p2");
        }

        static void Task1p3()
        {
            Console.WriteLine("Task1p3");
        }

        static void Task2p1()
        {
            Console.WriteLine("Task2p1");
        }

        static void Task2p2()
        {
            Console.WriteLine("Task2p2");
        }

        static void Task2p3()
        {
            Console.WriteLine("Task2p3");
        }

        static void Task2p4()
        {
            Console.WriteLine("Task2p4");
        }

        static void Task3p1()
        {
            Console.WriteLine("Task3p1");
        }
    }
}