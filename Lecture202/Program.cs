using Lecture202.Class_collection;

namespace Lecture202
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
            Numbers num = new Numbers();

            num.Add(1);
            num.Add(55);
            num.Add(-34);

            num.Print();
            
        }

        static void Task1p2()
        {
            Rectangle r = new Rectangle();  
            r.Height = 69;
            r.Width = 420;

            Console.WriteLine(r.Area());
            Console.WriteLine(r.Perimeter());
        }

        static void Task1p3()
        {
            Circle circle = new Circle();
            circle.Radius = 10;

            Console.WriteLine(circle.Area());
            Console.WriteLine(circle.Circumference());
        }

        static void Task1p4()
        {
            Library l = new Library();
            l.AddBook("Harry Potter");
            l.AddBook("Great Gatsby");
            l.AddBook("Programming for Dummies");

            foreach(string book in l.Books) { Console.WriteLine(book); }
            Console.WriteLine();

            l.RemoveBook("Harry Potter");
            foreach (string book in l.Books) { Console.WriteLine(book); }
            Console.WriteLine();



            Book book1 = new Book();
            book1.Author = "Rowling";
            book1.Year = 1997;
            book1.Title = "Harry Potter 2";
            book1.Id = 987654;

            Book book2 = new Book();
            book2.Author = "Ritchie";
            book2.Year = 1978;
            book2.Title = "The C Programming language";
            book2.Id = 123456;


            Book book3 = new Book();
            book3.Author = "Chomsky";
            book3.Year = 1988;
            book3.Title = "Manufacturing consent";
            book3.Id = 7410258;

            l.AddBookObj(book1);
            l.AddBookObj(book2);
            l.AddBookObj(book3);

            foreach (var bookobj in l.BookObjs)
            {
                Console.WriteLine(bookobj.Title);
            }
            Console.WriteLine();

            l.RemoveBookObj(book3);
            foreach (var bookobj in l.BookObjs)
            {
                Console.WriteLine(bookobj.Title);
            }
            Console.WriteLine();

        }

        static void Task2p1()
        {
            
            Song s1 = new Song("Black Milk", "Massive Attack", "Mezzanine", 381, "TripHop");
            Song s2 = new Song("Roads", "Portishead", "Dummy", 304, "TripHop");
            Song s3 = new Song("Wandering Star", "Portishead", "Dummy", 297, "TripHop");
            Song s4 = new Song("Reimagined", "The Contortionist", "Clairvoyant", 202, "Metal");
            Song s5 = new Song("Kairos", "Sepultura", "Kairos", 214, "Metal");
            Song s6 = new Song("Ratamahatta", "Sepultura", "Roots", 270, "Metal");
            Song s7 = new Song("Dusted", "Sepultura", "Roots", 270, "Metal");

            Playlist triphopPlaylist = new Playlist("TripHop", "Chill stuff");
            triphopPlaylist.AddSong(s1);
            triphopPlaylist.AddSong(s2);
            triphopPlaylist.AddSong(s3);

            Playlist metalPlaylist = new Playlist("Metal", "Headbanger stuff");
            metalPlaylist.AddSong(s4);
            metalPlaylist.AddSong(s5);
            metalPlaylist.AddSong(s6);
            metalPlaylist.AddSong(s7);

            Console.WriteLine("The list of trip-hop songs:");
            foreach (Song song in triphopPlaylist.SongList)
            {
                Console.WriteLine($"{song.Name} by artist {song.Artist}");
            }

            Console.WriteLine("The list of metal songs:");
            foreach (Song song in metalPlaylist.SongList)
            {
                Console.WriteLine($"{song.Name} by artist {song.Artist}");
            }
        }

        static void Task2p2()
        {
            Movie movie = new Movie("Don't look up", "Comedy");
            movie.Rate(7);
            movie.Rate(8);
            movie.Rate(7);
            movie.Rate(8);
            movie.Rate(9);
            movie.Rate(10);
            movie.Rate(5); //~7,7
            

            if (movie.Recommended())
            {
                Console.WriteLine($"Recommended to watch {movie.Title}");
            }

            Movie movie1 = new Movie("The Matrix", "Action");
            movie1.Rate(3);
            movie1.Rate(4);
            movie1.Rate(4);
            movie1.Rate(6);
            movie1.Rate(3);
            if (movie1.Recommended())
            {
                Console.WriteLine($"Recommended to watch {movie1.Title}");
            }
        }

        static void Task2p3()
        {
            Book book = new Book(123456,"Harry Potter pt3", "J.K.Rowling", 1999, 317);
            Console.WriteLine(book.ReadTime());
            Console.WriteLine();
        }

        static void Task2p4()
        {
            Computer computer = new Computer("MyPC", "Dell", 16, 512);
            Console.WriteLine(computer.CheckIfResourcesAreAvailable(8, 256));
        }

    }
}