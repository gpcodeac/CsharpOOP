using Lecture207.Classes;
using System.Diagnostics;

namespace Lecture207
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
            string nullStr = default;
            Validation<string>.Validate(nullStr);

            string emptyStr = "";
            Validation<string>.Validate(emptyStr);

            bool boolToValidate = default;
            Validation<bool>.Validate(boolToValidate);
            
            int i = default;
            Validation<int>.Validate(i);

            int? j = default;
            j = null;
            Validation<int?>.Validate(j);

            TestClass testClass = default;
            Validation<TestClass>.Validate(testClass);

            TestClass testClass2 = new TestClass();
            Validation<TestClass>.Validate(testClass2);

            TestClass testClass3 = null;
            Validation<TestClass>.Validate(testClass3);

            string userInput = Console.ReadLine();  
            Validation<string>.Validate(userInput);

        }
  
        static void Task2p1()
        {
            string nullStr = default;
            Validation2.Validate(nullStr);

            string emptyStr = "";
            Validation2.Validate(emptyStr);

            bool boolToValidate = default;
            Validation2.Validate(boolToValidate);

            int i = default;
            Validation2.Validate(i);

            int? j = default;
            j = null;
            Validation2.Validate(j);

            TestClass testClass = default;
            Validation2.Validate(testClass);

            TestClass testClass2 = new TestClass();
            Validation2.Validate(testClass2);

            TestClass testClass3 = null;
            Validation2.Validate(testClass3);

            string userInput = Console.ReadLine();
            Validation2.Validate(userInput);
        }
 
        static void Task3p1()
        {
            //PrintTwoTypes<int, string>();

            string nullStr = default;
            bool boolToValidate = default;
            PrintTwoTypes(nullStr, boolToValidate);
            Console.WriteLine();

            string emptyStr = "";
            int i = default;
            PrintTwoTypes(emptyStr, i);
            Console.WriteLine();

            int? j = default;
            j = null;
            TestClass testClass = null;
            PrintTwoTypes(j, testClass);
            Console.WriteLine();

            int k = 42;
            TestClass testClass2 = new TestClass();
            PrintTwoTypes(k, testClass2);
            Console.WriteLine();

            string userInput = Console.ReadLine();
            TestClass testClass3 = new TestClass(userInput, 69);
            PrintTwoTypes(userInput, testClass3);
            Console.WriteLine();

        }

        static void PrintTwoTypes<T, U>(T param1, U param2)
        {
            Console.WriteLine($"Type of T is '{typeof(T)}'. The value of T is '{param1}'.");
            Console.WriteLine($"Type of U is '{typeof(U)}'. The value of U is '{param2}'.");
        }


        static void Task4p1()
        {
            MyList<TestClass> myList = new MyList<TestClass>();
            TestClass testClass = new TestClass("test", 1);
            myList.Add(testClass);
            TestClass testClass2 = new TestClass("test2", 2);
            myList.Add(testClass2);
            TestClass testClass3 = new TestClass("test3", 3);
            myList.Add(testClass3);
            TestClass testClass4 = new TestClass("test4", 4);
            myList.Add(testClass4);
            TestClass testClass5 = new TestClass("test5", 5);
            myList.Add(testClass5);

            myList.RemoveItem(testClass2);
            myList.RemoveItemFromArr(testClass4);

            foreach (var item in myList)
            {
                Console.WriteLine($"Text: {item.Text}, Number: {item.Number}");
            }
        }


        static void Test0()
        {
            List<int> values = new() { 1, 2, 3 };
            var (a, b, c) = values;
            Console.WriteLine($"{a} {b} {c}");
            //int result = Test0Print(values);

        }

        static int Test0Print(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

    }


    //for Test0, deconstructs list into 3 variables
    static class IEnumerableDeconstructs
    {
        public static void Deconstruct<T>(this IEnumerable<T> values, out T a, out T b)
        {
            IEnumerator<T> enumerator = values.GetEnumerator();
            enumerator.MoveNext();
            a = enumerator.Current;
            enumerator.MoveNext();
            b = enumerator.Current;
        }

        public static void Deconstruct<T>(this IEnumerable<T> values, out T a, out T b, out T c)
        {
            IEnumerator<T> enumerator = values.GetEnumerator();
            enumerator.MoveNext();
            a = enumerator.Current;
            enumerator.MoveNext();
            b = enumerator.Current;
            enumerator.MoveNext();
            c = enumerator.Current;
        }
    }
}