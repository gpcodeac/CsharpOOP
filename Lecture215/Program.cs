using Lecture215.Classes;
using System;
using System.Reflection.Metadata;

namespace Lecture215
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
            Console.WriteLine("Task1p1\n");
            List<IAnimal> listIAnimal = new List<IAnimal>();
            List<IFish> listIFish = new List<IFish>();
            List<IMammal> listIMammal = new List<IMammal>();

            Cat cat = new Cat();
            Dog dog = new Dog();
            Bass bass = new Bass();
            Carp carp = new Carp();

            listIAnimal.Add(bass);
            listIAnimal.Add(carp);
            listIAnimal.Add(cat);
            listIAnimal.Add(dog);

            listIFish.Add(bass);
            listIFish.Add(carp);
            //listIFish.Add(cat);
            //listIFish.Add(dog);

            //listIMammal.Add(carp);
            //listIMammal.Add(bass);
            listIMammal.Add(cat);
            listIMammal.Add(dog);



            foreach (var animal in listIAnimal)
            {
                animal.Fight();
                animal.Flee();
                animal.Feed();
                animal.Mate();
                //animal.Swim();
                //animal.Bark();
            }
            Console.WriteLine();

            foreach (var fish in listIFish)
            {
                fish.Fight();
                fish.Flee();
                fish.Feed();
                fish.Mate();
                fish.Swim();
                //fish.Spawn();
                //fish.Bark();
            }
            Console.WriteLine();

            foreach (var mammal in listIMammal)
            {
                mammal.Fight();
                mammal.Flee();
                mammal.Feed();
                mammal.Mate();
                //mammal.Swim();
                //mammal.Bark();
                //mammal.Sleep();
                mammal.GiveBirth();
            }
            Console.WriteLine();

            Console.WriteLine(listIMammal[1].CompareTo(listIMammal[0]));
            Console.WriteLine(cat.CompareTo(dog));
            Console.WriteLine(dog.CompareTo(cat));
            Console.WriteLine(dog.CompareTo(bass));
            Console.WriteLine(bass.CompareTo(carp));
        }

        static void Task2p1()
        {
            Console.WriteLine("Task2p1\n");
            try
            {
                Triangle triangle = new Triangle(3, 4, 5);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("next instruciton");


            Quadrilateral quadrilateral = new Quadrilateral(4, 3, 4, 3, 5);
            Console.WriteLine("Area: " + quadrilateral.GetArea());
            Quadrilateral quadrilateral2 = new Quadrilateral(3, 5, 3, 5, 4);
            Console.WriteLine("Area: " + quadrilateral2.GetArea());
            Quadrilateral quadrilateral3 = new Quadrilateral(1, 1, 8, 8, Math.Sqrt(2));
            Console.WriteLine("Area: " + quadrilateral3.GetArea());
            Quadrilateral quadrilateral4 = new Quadrilateral(5, 5, 6, 6, 6);
            Console.WriteLine("Area: " + quadrilateral4.GetArea());

            quadrilateral4.CompareTo(quadrilateral3);

        }

        static void Task3p1()
        {
            foreach (var b in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(b);
            }
            
            Console.WriteLine();

            foreach (var b in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine(b);
            }

            Enum.TryParse("Monday", out WeekDays day);
        }

        enum Months
        {
            January, February, March, April, May, June, July, August, September, October, November, December
        }

    }
}