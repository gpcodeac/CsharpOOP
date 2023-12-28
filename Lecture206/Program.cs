namespace Lecture206
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
                case "3.1":
                    Task3p1();
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
            string path = "TextFile1.txt";
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
            Console.WriteLine();
        }

        static void Task1p2()
        {
            List<string> lines = new List<string>()
            {
                "Jingle bells, jingle bells",
                "Jingle all the way",
                "Oh, what fun it is to write",
                "The TextFile2 from this array"
            };
            string path = "TextFile2.txt"; //writes straight to [solution]\Lecture206\bin\Debug\net7.0\TextFile2.txt
            File.WriteAllLines(path, lines);
            Console.WriteLine("done");
        }

        static void Task1p3()
        {
            string src = @"D:\longtext.txt";
            string dest = @"longtext_copy.txt"; //copies straight to [solution]\Lecture206\bin\Debug\net7.0\TextFile2.txt
            File.Copy(src, dest);
            Console.WriteLine("done");
        }

        static void Task2p1()
        {
            string path = "TextFile1.txt";
            IEnumerable<string> lines = File.ReadLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line.Length.ToString().PadRight(4) + "|  " + line);
            }
        }

        static void Task2p2()
        {
            string JB =
                """
                [Verse 1]
                Dashing through the snow
                In a one-horse open sleigh
                O'er the fields we go
                Laughing all the way
                Bells on bobtails ring
                Making spirits bright
                What fun it is to ride and sing
                A sleighing song tonight

                [Chorus]
                Oh! Jingle bells, jingle bells
                Jingle all the way
                Oh, what fun it is to ride
                In a one-horse open sleigh, hey
                Jingle bells, jingle bells
                Jingle all the way
                Oh, what fun it is to ride
                In a one-horse open sleigh

                [Verse 2]
                A day or two ago
                I thought I'd take a ride
                And soon, Miss Fanny Bright
                Was seated by my side
                The horse was lean and lank
                Misfortune seemed his lot
                He got into a drifted bank
                And then we got upsot
                You might also like
                Silent Night
                Christmas Songs
                O Holy Night
                Christmas Songs
                The Twelve Days of Christmas
                Christmas Songs
                [Chorus]
                Hey, jingle bells, jingle bells
                Jingle all the way
                Oh, what fun it is to ride
                In a one-horse open sleigh, hey
                Jingle bells, jingle bells
                Jingle all the way
                Oh, what fun it is to ride
                In a one-horse open sleigh
                """;
            string path = "TextFile3.txt"; //writes straight to [solution]\Lecture206\bin\Debug\net7.0\TextFile3.txt
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.Write(JB);
            }
            Console.WriteLine("done");
        }

        static void Task2p3()
        {
            Console.WriteLine("Enter some text. To finalize enter null char.\n");
            string inputLine = "";
            string path = "TextFile4.txt"; //writes straight to [solution]\Lecture206\bin\Debug\net7.0\TextFile4.txt
            using (var stream = File.Open(path, FileMode.Create))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(stream))
                {
                    //while ((inputLine = Console.ReadLine()) != null)
                    //{
                    //    binaryWriter.Write(inputLine + "\r\n");
                    //}

                    binaryWriter.Write("hello");
                    binaryWriter.Write(12);
                    binaryWriter.Write('#');
                    binaryWriter.Write('$');
                    binaryWriter.Write("#$");

                    //binaryWriter.Write((byte)104);
                    //binaryWriter.Write((byte)101);
                    //binaryWriter.Write((byte)108);
                    //binaryWriter.Write((byte)108);
                    //binaryWriter.Write((byte)111); 
                    //binaryWriter.Write((byte)44);
                    //binaryWriter.Write((byte)32);
                    //binaryWriter.Write((byte)119);
                    //binaryWriter.Write((byte)111);
                    //binaryWriter.Write((byte)104);
                    //binaryWriter.Write((byte)108);
                    //binaryWriter.Write((byte)100);
                    //binaryWriter.Write((byte)33);
                }
            }
            Console.WriteLine("File saved.\n\n");


            string myString = "Hello world!";
            char[] myCharArr = myString.ToCharArray();


            Console.WriteLine("File content in bytes:");
            using (var stream = File.Open(path, FileMode.Open))
            {
                using (BinaryReader binaryReader = new BinaryReader(stream))
                {
                    int i = 0;
                    while (i < stream.Length)
                    {
                        byte byteFromStream = binaryReader.ReadByte();
                        Console.WriteLine(byteFromStream);
                        i++;
                    }
                }
            }
            Console.WriteLine("\n");


            Console.WriteLine("File content in chars:");
            using (var stream = File.Open(path, FileMode.Open))
            {
                using (BinaryReader binaryReader = new BinaryReader(stream))
                {
                    int i = 0;
                    while (i < stream.Length)
                    {
                        char charFromStream = binaryReader.ReadChar();
                        Console.WriteLine(charFromStream);
                        i++;
                    }
                }
            }
            Console.WriteLine("\n");


            Console.WriteLine("File content in just with Read method:");
            using (var stream = File.Open(path, FileMode.Open))
            {
                using (BinaryReader binaryReader = new BinaryReader(stream))
                {
                    int i = 0;
                    while (i < stream.Length)
                    {
                        int intFromRead= binaryReader.Read();
                        Console.WriteLine(intFromRead.ToString());
                        i++;
                    }
                }
            }
            Console.WriteLine("\n");

        }

        static void Task3p1()
        {

        }
    }
}