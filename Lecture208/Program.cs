using Lecture208.Classes;

namespace Lecture208
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
            string nullStr = default;

            string emptyStr = "";

            bool boolToValidate = default;

            int i = default;

            int? j = default;
            j = null;

            TestClass testClass = default;

            TestClass testClass2 = new TestClass();

            TestClass testClass3 = null;




            TestClass testClass4 = new TestClass("test string", 111);

            //string userInput = Console.ReadLine();

            TwoTypeClass<int , TestClass> twoTypeClass = new TwoTypeClass<int, TestClass>();
            twoTypeClass.SetT(42);
            twoTypeClass.SetU(testClass4);
            twoTypeClass.DisplayT();
            twoTypeClass.DisplayU();

            Console.WriteLine(twoTypeClass.ToString());
            
        }
        
        static void Task2p1()
        {
            FourSidedGeometricShape parallelogram = new FourSidedGeometricShape("Parallelogram", 6, 9);
            FourSidedGeometricShape trapezoid = new FourSidedGeometricShape("Trapezoid", 4, 20);

            Generator<FourSidedGeometricShape>.Show(parallelogram);
            Generator<FourSidedGeometricShape>.Show(trapezoid);

            int i = 1337;
            Generator<int>.Show(i);
        }

        static void Task3p1()
        {
            TestClass testClass = new TestClass("TEST CLASS TEXT", 777);
            string hw = "Hello World!";

            Type<TestClass, string> type = new Type<TestClass, string>(testClass, hw);

            Console.WriteLine(type.GetType(testClass));
            Console.WriteLine(type.GetType(hw));
            Console.WriteLine(type.GetType(58));
        }

        static void Task4p1()
        {
            Team<RoadCycling> ineosCycling = new Team<RoadCycling>("INEOS", 2010, 30);
            Team<RoadCycling> jumboVismaCycling = new Team<RoadCycling>("Jumbo-Visma", 2010, 30);
            Team<RoadCycling> boraHansgroheCycling = new Team<RoadCycling>("Bora-Hansgrohe", 1984, 30);
            Team<Football> manchesterUnited = new Team<Football>("Manchester United", 1878, 30);
            Team<Football> liverpool = new Team<Football>("Liverpool", 1892, 30);
            League<RoadCycling> tourDeFrance = new League<RoadCycling>("Tour de France", 1903);
            League<Football> premierLeague = new League<Football>("Premier League", 1992);
            tourDeFrance.AddTeam(ineosCycling);
            tourDeFrance.AddTeam(jumboVismaCycling);
            tourDeFrance.AddTeam(boraHansgroheCycling);
            premierLeague.AddTeam(manchesterUnited);
            premierLeague.AddTeam(liverpool);

            
            tourDeFrance.ShowTeams();

            premierLeague.ShowTeams();

            //Team<string> myt = new Team<string>("myt", 2020, 30);
        }

        static void Test0()
        {

        }
    }
}