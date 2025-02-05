﻿using Lecture214.Classes_and_Interfaces;

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
                case "2.1":
                    Task2p1();
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
            //Car juodasGolfas = new Car("Golfas", 20);
            //juodasGolfas.Drive();
            //Console.WriteLine(juodasGolfas.Fuel);
            //Thread.Sleep(5000);
            //juodasGolfas.Stop();
            //Console.WriteLine(juodasGolfas.Fuel);
        }

        static void Task2p1()
        {
            Console.WriteLine("Task2p1");

            BMWCar juodasBemve = new BMWCar("Bemve", 20);
            juodasBemve.IsXDrive = true;
            juodasBemve.Drive();
            Console.WriteLine(juodasBemve.Fuel);
            Thread.Sleep(5000);
            juodasBemve.Stop();
            Console.WriteLine(juodasBemve.Fuel);

            AudiCar silverAudi = new AudiCar("Silke", 5);
            silverAudi.IsQuattro = true;
            silverAudi.Drive();
            Console.WriteLine(silverAudi.Fuel);
            Thread.Sleep(5000);
            silverAudi.Stop();
            Console.WriteLine(silverAudi.Fuel);
        }

        static void Task3p1()
        {
            Console.WriteLine("Task3p1");
            AudiCar silverAudi = new AudiCar("Silke", 5);
            BMWCar juodasBemve = new BMWCar("Bemve", 20);
            CarComparer comparer = new CarComparer();
            Console.WriteLine(comparer.Compare(silverAudi, juodasBemve));

            AudiCar silverAudi2 = null;
            Console.WriteLine(comparer.Compare(silverAudi2, juodasBemve));
        }
    }
}