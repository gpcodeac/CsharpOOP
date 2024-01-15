using Lecture212.Delegates;
using System.Collections;
using System.Reflection;
using static Lecture212.Delegates.MyDelegates;

namespace Lecture212
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
                case "5.1":
                    Task5p1();
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
        }


        static void Task1p1()
        {
            StrDelegate strMultiply = MultiplyInfo;
            StrDelegate strPrint = PrintInfo;

            StrDelegateConsumer(strPrint);
            Console.WriteLine();
            StrDelegateConsumer(strMultiply);
            Console.WriteLine();
        }

        static void StrDelegateConsumer(StrDelegate method)
        {
            Console.WriteLine(method("john", "cena", 5));
        }


        static void Task2p1()
        {
            //IntDelegate method = BitXOR;
            //int.TryParse(Console.ReadLine(), out int val1);
            //int.TryParse(Console.ReadLine(), out int val2);
            //int result = method(val1, val2);    

            //Console.WriteLine("XORed: " + result);

            //if (result > val1 && result > val2)
            //{
            //    method = Subtract;
            //    result = method(val1, val2);
            //    Console.WriteLine("Subtracted: " + result);
            //}
            //else
            //{
            //    method = Add;
            //    result = method(val1, val2);
            //    Console.WriteLine("Added: " + result);
            //}
            //Console.WriteLine();


            int[] arr1 = new int[1];
            int.TryParse(Console.ReadLine(), out arr1[0]);
            int[] arr2 = new int[1];
            int.TryParse(Console.ReadLine(), out arr2[0]);
            BitArray bit1 = new BitArray(arr1);
            BitArray bit2 = new BitArray(arr2);
            BitArray result = new BitArray(32);

            BoolDelegate xor = BoolXOR;
            BoolDelegate and = BoolAND;
            BoolDelegate or = BoolOR;

            //BoolDelegate test = xor;
            //test+= or;
            //test+= and;
            //test.Invoke(true, false);
            //Delegate[] il = test.GetInvocationList();
            //MethodInfo mi = test.GetMethodInfo();
            //test.Invoke(true, false);


            bool c = false;
            for (int i = 0; i < 32; i++)
            {
                result[i] = xor(xor(bit1[i], bit2[i]), c);
                c = or(and(xor(bit1[i], bit2[i]), c), and(bit1[i], bit2[i]));
            }

            int[] arr3 = new int[1];
            result.CopyTo(arr3, 0);
            Console.WriteLine("Answer is: " + arr3[0]);
        }


        static void Task3p1()
        {
            ListDelegate method = ListEveryOther;
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            List<int> result = method(list, 2);
            Console.WriteLine(string.Join(", ", result));
        }


        static void Task4p1()
        {
            int result = MyDelegates.Subtract(MyDelegates.Add(1, 2), 5);
            Console.WriteLine(result);

        }

        static void Task5p1()
        {
            Console.WriteLine("Task5p1");
            InlinedMethod2();   
            static void InlinedMethod()
            {
                Console.WriteLine("InlinedMethod");
            }

            static void InlinedMethod2()
            {
                Console.WriteLine("InlinedMethod2");
            }

        }
    }
}