using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml;
using Lecture213.Classes;

namespace Lecture213
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
                case "1.4":
                    Task1p4();
                    break;
                case "1.5":
                    Task1p5();
                    break;
                case "1.6":
                    Task1p6();
                    break;
                case "1.7":
                    Task1p7();
                    break;

                case "2.1":
                    Task2p1();
                    break;
                case "2.2":
                    Task2p2();
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
            List<int> numbers = new() { 1, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };


            List<int> squares1 = numbers.Select(x => x * x).ToList();
            Console.WriteLine("Squares1: " + string.Join(", ", squares1));

            List<int> squares2 = new();
            numbers.ForEach(x => squares2.Add(x * x));
            Console.WriteLine("Squares2: " + string.Join(", ", squares2));

            List<int> squares3 =
                (from num in numbers
                 select num * num).ToList();
            Console.WriteLine("Squares3: " + string.Join(", ", squares3));

            Func<int, int> pow2 = x => x * x;
            List<int> squares4 = numbers.Select(pow2).ToList();
            Console.WriteLine("Squares4: " + string.Join(", ", squares4));

            Func<List<int>, List<int>> squareList = x => x.Select(y => y * y).ToList();
            List<int> squares5 = squareList(numbers);
            Console.WriteLine("Squares5: " + string.Join(", ", squares5));

            List<int> squares6 = numbers.Select(Square).ToList();
            Console.WriteLine("Squares6: " + string.Join(", ", squares6));

            //Func<List<object>, List<object>> squareList2 = x => x.Select(y => (object)(Convert.ToDouble(y) * Convert.ToDouble(y))).ToList();
            //List<int> squares6 = squareList2(numbers);
            //Console.WriteLine("Squares6: " + string.Join(", ", squares6));
        }

        static int Square(int x)
        {
            return x * x;
        }

        static void Task1p2()
        {
            Random rnd = new();
            List<int> numbers = Enumerable.Range(1, 10).Select(x => rnd.Next(-20, 20)).OrderBy(x => x).ToList();
            Console.WriteLine("Random numbers: " + string.Join(", ", numbers));
            List<int> positiveNumbers = numbers.Where(x => x > 0).ToList();
            Console.WriteLine("Positive numbers: " + string.Join(", ", positiveNumbers));
        }

        static void Task1p3()
        {
            List<int> numbers = new() { -20, -10, -7, -5, -3, 0, 2, 5, 8, 10, 15, 35, 45 };
            List<int> positiveNumbers = numbers.Where(x => x > 0 && x <= 10).ToList();
            Console.WriteLine(string.Join(", ", positiveNumbers));
        }

        static void Task1p4()
        {
            Random rnd = new();
            List<int> numbers = Enumerable.Range(1, 10).Select(x => rnd.Next(50)).ToList();
            Console.WriteLine("Random numbers: " + string.Join(", ", numbers));
            List<int> sortedNumbersASC = numbers.OrderBy(x => x).ToList();
            Console.WriteLine("Sorted numbers ASC: " + string.Join(", ", sortedNumbersASC));
            List<int> sortedNumbersDESC = numbers.OrderByDescending(x => x).ToList();
            Console.WriteLine("Sorted numbers DESC: " + string.Join(", ", sortedNumbersDESC));
        }

        static void Task1p5()
        {

        }

        static void Task1p6()
        {
            Random rnd = new();
            List<int> numbers = Enumerable.Range(1, 10).Select(x => rnd.Next(50)).ToList();
            Console.WriteLine("Random numbers: " + string.Join(", ", numbers));
            int largest = numbers.Max();
            Console.WriteLine("Largest number: " + largest);
        }

        static void Task1p7()
        {
            List<Person> people = Enumerable.Range(1, 10).Select(x => new Person($"PersonName{x}", 20 + x * 3)).ToList();
            people[1].Name = "Alice";
            people[5].Name = "Anna";
            people[7].Name = "Arnold";
            people[8].Name = "Alfred";
            people.ForEach(x => Console.WriteLine("Name: " + x.Name.ToString().PadRight(15) + "|  Age: " + x.Age));
            Console.WriteLine();
            //var x = people.Select(x =>
            //{
            //    Console.WriteLine($"Name: {x.Name}  | Age: {x.Age}"); // This only creates a delegate, but does not execute it.
            //    return true;
            //});
            //foreach (var item in x)
            //{
            //    Console.WriteLine(item); // This executes the delegate. And does so iteratively.
            //}
            //x.ToList();
            List<string> names = people.Select(x => x.Name).ToList();
            Console.WriteLine("Names: " + string.Join(", ", names));
            List<int> ages = people.Select(x => x.Age).ToList();
            Console.WriteLine("Ages: " + string.Join(", ", ages));
            Console.WriteLine();

            people = people.OrderByDescending(x => x.Age).ToList();
            people.ForEach(x => Console.WriteLine("Name: " + x.Name.ToString().PadRight(15) + "|  Age: " + x.Age));
            Console.WriteLine();

            List<Person> peopleA = people.Where(x => x.Name.StartsWith("A")).ToList();
            peopleA.ForEach(x => Console.WriteLine("Name: " + x.Name.ToString().PadRight(15) + "|  Age: " + x.Age));
            Console.WriteLine();

            List<Person> peopleOver40 = people.Where(x => x.Age > 40).OrderBy(x => x.Name).ToList();
            peopleOver40.ForEach(x => Console.WriteLine("Name: " + x.Name.ToString().PadRight(15) + "|  Age: " + x.Age));
            Console.WriteLine();
        }

        static void Task2p1()
        {
            Person person1 = new("Alice", 20);
            Person person2 = new("Bob", 30);
            Person person3 = new("Charlie", 40);
            Person person4 = new("David", 50);
            Person person5 = new("Eric", 60);
            List<Person> people = new() { person1, person2, person3, person4, person5 };

            Animal animal1 = new("Alpaca", 5);
            Animal animal2 = new("Bear", 7);
            Animal animal3 = new("Cat", 9);
            Animal animal4 = new("Dog", 11);
            Animal animal5 = new("Eagle", 13);
            List<Animal> animals = new() { animal1, animal2, animal3, animal4, animal5 };

            person1.AddAnimal(animal1);
            person1.AddAnimal(animal3);
            person2.AddAnimal(animal2);
            person2.AddAnimal(animal4);
            person3.AddAnimal(animal3);
            person3.AddAnimal(animal5);
            person4.listOfAnimals = animals.ToList();

            List<Animal> animalsBelongingToPeople = people.SelectMany(x => x.listOfAnimals).ToList();
            foreach (var animal in animalsBelongingToPeople)
            {
                Console.WriteLine(animal.Name);
            }
            Console.WriteLine();

            List<string> animalsBelongingToPeople2 = people.SelectMany(x => x.listOfAnimals.Select(y => y.Name)).ToList();
            foreach (var animalName in animalsBelongingToPeople2)
            {
                Console.WriteLine(animalName);
            }
            Console.WriteLine();

            List<Animal> animalsBelongingToPeople3 = people.Select(x => x.listOfAnimals).Aggregate(new List<Animal>(), (acc, list) => { acc.AddRange(list); return acc; });
            foreach (var animal in animalsBelongingToPeople3)
            {
                Console.WriteLine(animal.Name);
            }
            Console.WriteLine();

            //List<Animal> animals1 = new();
            //List<Animal> animalsBelongingToPeople4 = people.Select<Person,Animal>(x => 
            //{
            //    IEnumerable<Animal> a = x.listOfAnimals.Select<Animal, Animal>(y =>
            //    {
            //        return y;
            //    });
            //    List<Animal> b = a.ToList();
            //    return a;
            //}).ToList();

            List<Animal> animalsStartingWithA = people.SelectMany(x => x.listOfAnimals.Where(y => y.Name.StartsWith("A"))).ToList();
            foreach (var animal in animalsStartingWithA)
            {
                Console.WriteLine(animal.Name);
            }
            Console.WriteLine();

            List<Animal> animalsStartingWithAandOlderThan5 = people.SelectMany(x => x.listOfAnimals.Where(y => y.Name.StartsWith("A") && y.Age > 5)).ToList();
            foreach (var animal in animalsStartingWithAandOlderThan5)
            {
                Console.WriteLine(animal.Name);
            }
            Console.WriteLine();

        }

        static void Task2p2()
        {
            Console.WriteLine("Please enter some text:");
            string text = Console.ReadLine();
            List<string> words = text.Replace(",", "").Split(' ').ToList();
            List<string> uppercaseWords = words.Where(x => x == x.ToUpper()).ToList();
            foreach (var word in uppercaseWords)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();

            List<string> uppercaseWords2 = words.Where(x => x.All(Char.IsUpper)).ToList();
            foreach (var word in uppercaseWords2)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();
        }

        static void Task3p1()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\gzms\Desktop\gz documents\Code Academy\");
            List<FileInfo> fileInfos = directoryInfo.GetFiles().ToList();
            List<string> fileNames = fileInfos.Select(x => x.Name).ToList();
            foreach (var fileName in fileNames)
            {
                Console.WriteLine(fileName);
            }
            Console.WriteLine();

            List<FileInfo> txtFiles = directoryInfo.GetFiles().Where(x => x.Name.EndsWith(".txt")).ToList();
            foreach (var txtFile in txtFiles)
            {
                Console.WriteLine(txtFile);
                Console.WriteLine(txtFile.Name);
            }
            Console.WriteLine();

            List<string> txtFiles2 = fileInfos.Where(x => x.Name.EndsWith(".txt")).Select(x => x.Name).ToList();
            foreach (var txtFile in txtFiles2)
            {
                Console.WriteLine(txtFile);
            }
            Console.WriteLine();
        }

    }
}