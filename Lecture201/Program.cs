namespace Lecture201
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
                case "2.1":
                    Task2p1();
                    break;
                case "2.2":
                    Task2p2();
                    break;
                case "3.1":
                    Task3p1();
                    break;
                case "3.2":
                    Task3p2();
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



        static void Task1p1()
        {
            Person mydude = new Person("German", 33);
            Console.WriteLine($"My dude's name is {mydude.Name} and he is {mydude.Age} y.o.");

            Console.WriteLine();

            var someotherdude = new Person("Bob", 35, 191);
            Console.WriteLine($"Some other dude's name is {someotherdude.Name} and he is {someotherdude.Age} y.o. and {someotherdude.Height}cm tall.");
        }



        static void Task1p2()
        {
            School newschool = new School("Harvard", "Cambridge");
            Console.WriteLine($"The school name is {newschool.Name}");
            Console.WriteLine($"The school city is {newschool.City}");

            Console.WriteLine();

            School oldschool = new School("ISM", "Vilnius", 1800);
            Console.WriteLine($"The school name is {oldschool.Name}");
            Console.WriteLine($"The school city is {oldschool.City}");
            Console.WriteLine($"The school student enrollment is {oldschool.StudentCount}");
        }



        static void Task2p1()
        {
            Book potterPt1 = new Book("Harry Potter and the Philosopher's Stone", "J.K.Rowling", 1997);
            Console.WriteLine($"Book name is '{potterPt1.Title}'");
            Console.WriteLine($"Book author is {potterPt1.Author}");
            Console.WriteLine($"Book year is {potterPt1.Year}");

            Console.WriteLine();

            var bookOnC = new Book("The C Programming Language", "D.Ritchie", 1978, "USA");
            Console.WriteLine($"Book name is '{bookOnC.Title}'");
            Console.WriteLine($"Book author is {bookOnC.Author}");
            Console.WriteLine($"Book year is {bookOnC.Year}");
            Console.WriteLine($"Book publishing country is {bookOnC.CountryOfPublishing}");

            Console.WriteLine();


            Book potterPt2 = new Book("Harry Potter and the Chamber of Secrets", "J.K.Rowling", 1998);
            Book potterPt3 = new Book("Harry Potter and the Prisoner of Azkaban", "J.K.Rowling", 1999);
            Book potterPt5 = new Book("Harry Potter and the Order of the Phoenix", "J.K.Rowling", 2003);

            List<Book> library = new List<Book> { potterPt1, potterPt2, potterPt3, potterPt5, bookOnC };


            Console.WriteLine("Enter author name: ");
            string author = Console.ReadLine();
            List<string> booksByAuthor = BooksByAuthor(author, library);
            Console.WriteLine($"{author} wrote these books:\n");
            foreach (string book in booksByAuthor)
            {
                Console.WriteLine(book);
            }
        }

        static List<string> BooksByAuthor(string author, List<Book> library)
        {
            var outList = new List<string>();
            foreach (Book book in library)
            {
                if (book.Author == author)
                {
                    outList.Add(book.Title);
                }
            }
            return outList;
        }



        static void Task2p2()
        {
            List<Store> listOfStores = new List<Store>();

            Store foodStore = new Store("Maxima");
            listOfStores.Add(foodStore);
            foodStore.Year = 1992;
            foodStore.Products.Add("Dvaro Milk");
            foodStore.Products.Add("Pieno Zvaigzdes Butter");
            foodStore.Products.Add("Pork Meat");
            foodStore.Products.Add("Coca-cola");

            Store foodStore2 = new Store("Rimi");
            listOfStores.Add(foodStore2);
            foodStore2.Year = 2016;
            foodStore2.Products.Add("Lidl Milk");
            foodStore2.Products.Add("Lidl Butter");
            foodStore2.Products.Add("Pork Meat");
            foodStore2.Products.Add("Freeway cola");

            Store carPartsStore = new Store("Intercars");
            listOfStores.Add(carPartsStore);
            carPartsStore.Year = 1990;
            carPartsStore.Products.Add("Toyota Avensis door");
            carPartsStore.Products.Add("VW Golf Mk6 front bumper");
            carPartsStore.Products.Add("BMW E46 brake pads");

            List<string> autoaibeParts = new List<string>
            {
                "Toyota Avensis steering wheel",
                "VW Golf Mk6 rear bumper",
                "BMW E46 brake pads"
            };
            Store carPartsStore2 = new Store("Autoaibe", 1995, autoaibeParts);
            listOfStores.Add(carPartsStore2);

            foreach (var store in listOfStores)
            {
                foreach (var product in store.Products)
                {
                    Console.WriteLine($"{{{store.Name}}} {{{store.Year}}} - {{{product}}}");
                }
                Console.WriteLine();
            }
        }



        static void Task3p1()
        {
            Dog fluffy = new Dog("Fluffy", "Rotweiler", 7, false, "", "");

            Cat garfield = new Cat("Garfield", "", 5, false);

            Hamster hamster = new Hamster("Stewart Little", "White", 4);

            foreach (string name in GetAnimalName(fluffy, garfield, hamster))
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();


            Hamster hamster1 = new Hamster("Hummer", "Camo Grey", 3);
            Hamster hamster2 = new Hamster("TheRatBoy", "Black and Yellow", 6);
            Hamster hamster3 = new Hamster("WheelRunner2049", "White", 5);

            Dog dog1 = new Dog("Doggy1", "Angry breed", 5, true, "Doggy1Parent1", "Doggy1Parent2");
            Dog dog2 = new Dog("Doggy2", "Less angry breed", 2, false, "", "");
            Dog dog3 = new Dog("Doggy3", "Cheerful breed", 8, true, "Doggy3Parent1", "Doggy3Parent2");
            Dog dog4 = new Dog("Doggy4", "Happy breed", 1, false, "", "");

            Cat cat1 = new Cat();
            Cat cat2 = new Cat();


            List<Dog> dogs = new List<Dog>();
            List<Cat> cats = new List<Cat>();
            List<Hamster> hamsters = new List<Hamster>();
            dogs.Add(fluffy);
            dogs.Add(dog1);
            dogs.Add(dog2);
            dogs.Add(dog3);
            dogs.Add(dog4);
            cats.Add(garfield);
            cats.Add(cat1);
            cats.Add(cat2);
            hamsters.Add(hamster);
            hamsters.Add(hamster1);
            hamsters.Add(hamster2);
            hamsters.Add(hamster3);

            foreach (var kvPair in GetAnimalCount(dogs, cats, hamsters))
            {
                Console.WriteLine(kvPair.Key + " " + kvPair.Value);
            }
            Console.WriteLine();

        }

        static List<string> GetAnimalName(Dog dog, Cat cat, Hamster hamster)
        {
            var list = new List<string>();
            list.Add(dog.Name);
            list.Add(cat.Name);
            list.Add(hamster.Name);
            return list;
        }

        static Dictionary<string, int> GetAnimalCount(List<Dog> dogs, List<Cat> cats, List<Hamster> hamsters)
        {
            var countDict = new Dictionary<string, int>();
            countDict.Add("Dog", dogs.Count());
            countDict.Add("Cat", cats.Count());
            countDict.Add("Hamster", hamsters.Count());
            return countDict;
        }



        static void Task3p2()
        {
            Circle c = new Circle(5);
            Console.WriteLine(c.Radius);
            Console.WriteLine(c.Area);
            Console.WriteLine(c.Circumference);
            Console.WriteLine();

            Square s = new Square(3.3, 10);
            Console.WriteLine(s.Side1);
            Console.WriteLine(s.Side2);
            Console.WriteLine(s.Perimeter);
            Console.WriteLine(s.Area);
            Console.WriteLine(s.Side1);
            Console.WriteLine(s.Side2);
            Console.WriteLine();

            s.Side1 = 5;
            Console.WriteLine(s.Side1);
            Console.WriteLine(s.Side2);
            Console.WriteLine(s.Perimeter);
            Console.WriteLine(s.Area);
            Console.WriteLine();

            s.Side1 = 4;
            s.Side2 = 7;
            Console.WriteLine(s.Side1);
            Console.WriteLine(s.Side2);
            Console.WriteLine(s.Perimeter);
            Console.WriteLine(s.Area);
            Console.WriteLine();


            Triangle t = new Triangle(3, 4, 5);
            Console.WriteLine(t.Side1);
            Console.WriteLine(t.Side2);
            Console.WriteLine(t.Side3);
            Console.WriteLine(t.Perimeter);
            Console.WriteLine(t.Area);
            Console.WriteLine();

            t.Side1 = 2;
            Console.WriteLine(t.Side1);
            Console.WriteLine(t.Side2);
            Console.WriteLine(t.Side3);
            Console.WriteLine(t.Perimeter);
            Console.WriteLine(t.Area);
            Console.WriteLine();

        }



        static void Task4p1()
        {
            Car car = new Car();
            car.ModelName = "300SL";
            car.ManufactureYear = 1955;
            car.Engine.Capacity = 2996;
            car.Engine.FuelType = "Petrol";
            //car.Engine.Running = true;
            Console.WriteLine(car.ModelName + " " + 
                                car.ManufactureYear + " " + 
                                car.Engine.Capacity + " " + 
                                car.Engine.FuelType + " " + 
                                car.Engine.Running);

            car.StartEngine();
            Console.WriteLine(car.ModelName + " " +
                                car.ManufactureYear + " " +
                                car.Engine.Capacity + " " +
                                car.Engine.FuelType + " " +
                                car.Engine.Running);

            car.Engine.Stop();
            Console.WriteLine(car.ModelName + " " +
                                car.ManufactureYear + " " +
                                car.Engine.Capacity + " " +
                                car.Engine.FuelType + " " +
                                car.Engine.Running);

        }



        static void Task4p2()
        {

        }



        static void Test0()
        {
            PersonTest german = new PersonTest("GermanPaskovskij", "Male", new DateTime(1990, 03, 15));
            Console.WriteLine(german.DOB);
            Console.WriteLine(german.Name);

            Console.WriteLine();

            PersonTest german2 = new PersonTest("GermanP", "Male");
            Console.WriteLine(german2.DOB);
            Console.WriteLine(german2.Name);

            Console.WriteLine();

            PersonTest german3 = new PersonTest(null, "Male");
            Console.WriteLine(german3.DOB);
            Console.WriteLine(german3.Name);
        }
    }
}