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

            Store carPartsStore2 = new Store("Autoaibe");
            listOfStores.Add(carPartsStore2);
            carPartsStore2.Year = 1995;
            carPartsStore2.Products.Add("Toyota Avensis steering wheel");
            carPartsStore2.Products.Add("VW Golf Mk6 rear bumper");
            carPartsStore2.Products.Add("BMW E46 brake pads");

            foreach (var store in listOfStores)
            {
                foreach (var product in store.Products)
                {
                    Console.WriteLine($"{{{store.Name}}} {{{store.Year}}} - {{{product}}}");
                }
                Console.WriteLine();
            }


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