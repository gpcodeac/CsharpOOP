using Lecture209.Classes;

namespace Lecture209
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
            TestClass testClass = new TestClass("Some test class Nr1.", 35);
            TestClass testClass2 = new TestClass("Another test class Nr2.", 789);
            TestClass testClass3 = new TestClass("One more test class Nr3.", 199563);
            List<TestClass> testList = new List<TestClass>() { testClass, testClass2, testClass3, testClass };

            TestClass testClass4 = new TestClass("Test class not in List", 111222);

            ReadOnlyList<TestClass> readOnlyList = new ReadOnlyList<TestClass>(testList);

            Console.WriteLine("Printing list:");
            readOnlyList.Print();
            Console.WriteLine();

            Console.WriteLine("Printing array:");
            TestClass[] arr = readOnlyList.ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            try
            {
                Console.WriteLine(readOnlyList.FindIfUnique(testClass).ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }

            try
            {
                Console.WriteLine(readOnlyList.FindIfUnique(testClass2).ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine(readOnlyList.FindIfUnique(testClass4).ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



            try
            {
                Console.WriteLine(readOnlyList.FindIfUniqueOrNone(testClass).ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            try
            {
                Console.WriteLine(readOnlyList.FindIfUniqueOrNone(testClass2).ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            try
            {
                Console.WriteLine(readOnlyList.FindIfUniqueOrNone(testClass4).ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        

        static void Task2p1()
        {
            TestClass testClass = new TestClass("Some test class Nr1.", 35);
            TestClass testClass2 = new TestClass("Another test class Nr2.", 789);
            TestClass testClass3 = new TestClass("One more test class Nr3.", 199563);
            List<TestClass> testList = new List<TestClass>() { testClass, testClass2, testClass3, testClass };

            Task2GenericClass<TestClass> task2GenericClass = new Task2GenericClass<TestClass>(testList);

            TestClass testClass4 = new TestClass("And the last test class Nr4.", 111222);

            task2GenericClass.Add(testClass4);
            task2GenericClass.Remove(testClass2);

            Console.WriteLine("Printing task2 list:");
            task2GenericClass.Print();
            Console.WriteLine();

            Console.WriteLine("Printing task2 array:");
            TestClass[] arr = task2GenericClass.ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            TestClass newTestClass = new TestClass("New test class", 123456);
            List<TestClass> newList = new List<TestClass>() { newTestClass, newTestClass, newTestClass };
            Task2GenericClass<TestClass> task2GenericClass2 = new Task2GenericClass<TestClass>(newList);
            task2GenericClass.Merge(task2GenericClass2);
            Console.WriteLine("Printing task2 list merged:");
            task2GenericClass.Print();
            Console.WriteLine();

            task2GenericClass.RemoveAll(newTestClass);
            Console.WriteLine("Printing task2 list remove all:");
            task2GenericClass.Print();
            Console.WriteLine();
        }
        

        static void Task3p1()
        {

        }
        

        static void Task4p1()
        {

        }

    }
}