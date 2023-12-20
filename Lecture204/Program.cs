using Lecture204.Class_library;

namespace Lecture204
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
            Square square = new Square(5);
            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine(square.Area());
            Console.WriteLine(square.Perimeter());
            Console.WriteLine(triangle.Area());
            Console.WriteLine(triangle.Perimeter());
        }

        static void Task1p2()
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.MakeSound();
            dog.MakeSound();
        }

        static void Task1p3()
        {
            List<GeometricShape> shapes = new List<GeometricShape>()
            {
                new Square(5),
                new Triangle(3, 4, 5),
                new Square(7),
                new Triangle(1, 1, Math.Sqrt(2))
            };

            foreach (var item in shapes)
            {
                Console.WriteLine(item.Area());
                Console.WriteLine(item.Perimeter());
                Console.WriteLine();
            }
        }

        static void Task2p1()
        {
            Bus bus = new Bus(4200, 130, 50, true, 30, 20, true);
            Car car = new Car(1250, 200, 5, true, 5, true);
            Scooter scooter = new Scooter(20, 25, 1, false, 40, false);
            bus.PrintInfo();
            Console.WriteLine();
            car.PrintInfo();
            Console.WriteLine();
            scooter.PrintInfo();
        }

        static void Task2p2()
        {
            Bus bus = new Bus(4200, 130, 50, true, 30, 20, true);
            Car golf = new Car(1250, 200, 5, true, 5, true);
            Car porsche = new Car(1150, 280, 2, true, 2, false);
            Scooter scooter = new Scooter(20, 25, 1, false, 40, false);

            //Human human1 = new Human("Jan", "Kowalski");
            BusinessPerson human1 = new BusinessPerson("Jan", "Kowalski");

            human1.AddVehicle(golf);
            human1.AddVehicle(porsche);
            human1.AddVehicle(scooter);

            foreach (var item in human1.Vehicles)
            {
                if (item is Car c)
                {
                    Console.WriteLine("This is a car:");
                    c.PrintInfo();
                }
                else if (item is Bus b)
                {
                    Console.WriteLine("This is a bus:");
                    b.PrintInfo();
                }
                else if (item is Scooter s)
                {
                    Console.WriteLine("This is a scooter:");
                    s.PrintInfo();
                }
                Console.WriteLine();
            }
            human1.PrintInfo();
            Console.WriteLine();

            Teenager human2 = new Teenager("Bobby", "Fischer");
            human2.AddVehicle(scooter);
            human2.PrintInfo();
        }

    }
}