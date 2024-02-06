using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Threading.Channels;


namespace Lecture217
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
                case "1":
                    Task1();
                    break;
                case "2":
                    Task2();
                    Console.WriteLine("hello");
                    Thread.Sleep(1000);
                    break;
                case "2.2":
                    Task2p2();
                    Console.WriteLine("hello");
                    Thread.Sleep(1000);
                    break;
                case "2.3":
                    Task2p3();
                    Console.WriteLine("hello");
                    Thread.Sleep(1000);
                    break;
                case "2.4":
                    Task2p4();
                    Console.WriteLine("hello");
                    Thread.Sleep(1000);
                    break;
                case "2.5":
                    Task2p5();
                    Console.WriteLine("hello");
                    Thread.Sleep(1000);
                    break;
                case "2.6":
                    Task2p6();
                    Console.WriteLine("hello");
                    Thread.Sleep(1000);
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
            Game.MainGame();
        }


    




        static void Task1()
        {
            ProgressBar pb = new ProgressBar(0);
            pb.MoveProgressAsync();
            PrintProgressSync(pb);
            Console.WriteLine("End of Task1");
        }

        static void PrintProgressSync(ProgressBar pb)
        {
            while (pb.Progress < 100)
            {
                Thread.Sleep(300);
                Console.WriteLine(pb.Progress);
            }
        }





        static async void Task2()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("The constantly refreshing list of contents is.");
                string[] files = GetFilesAsync().Result; //await asynchronously unwraps the result of your task, whereas just using Result would block until the task had completed.
                await Console.Out.WriteLineAsync("Some text async");
                Console.WriteLine("some text");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
                Thread.Sleep(3000);
            }
        }

        static async void Task2p2()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("The constantly refreshing list of contents is.");
                string[] results = await GetFilesAsync();
                await Console.Out.WriteLineAsync("Some text async");
                Console.WriteLine("some text");
                foreach (string result in results)
                {
                    Console.WriteLine(result);
                }
                Thread.Sleep(3000);
            }
        }

        static async void Task2p3()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("The constantly refreshing list of contents is.");
                Task<string[]> resultTask = GetFilesAsync();
                resultTask.Wait();
                string[] results = resultTask.Result;
                await Console.Out.WriteLineAsync("Some text async");
                Console.WriteLine("some text");
                foreach (string result in results)
                {
                    Console.WriteLine(result);
                }
                Thread.Sleep(3000);
            }
        }

        static async Task<string[]> GetFilesAsync()
        {
            SomeWorkload();
            string path = @"C:\Users\gzms\Desktop";
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);
            string[] combined = files.Concat(directories).ToArray();
            //await Task.Delay(1500);
            return combined;
        }


        static async Task SomeWorkload()
        {
            await Task.Run( () => Console.ReadLine());
            Console.WriteLine("some workload");
        }


        static async Task SomeWorkload2()
        {
            Task.Run(() => Console.ReadLine());
            Console.WriteLine("some workload 2");
        }


        static async void Task2p4()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("The constantly refreshing list of contents is.");
                GetFilesAsync2().Wait();
                SomeWorkload2().Wait();
                await Console.Out.WriteLineAsync("Some text async");
                Console.WriteLine("some text");
                Thread.Sleep(3000);
            }
        }

        static async void Task2p5()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("The constantly refreshing list of contents is.");
                await GetFilesAsync2();
                await SomeWorkload2();
                await Console.Out.WriteLineAsync("Some text async");
                Console.WriteLine("some text");
                Thread.Sleep(3000);
            }
        }

        static async void Task2p6()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("The constantly refreshing list of contents is.");
                GetFilesAsync2();
                SomeWorkload2();
                await Console.Out.WriteLineAsync("Some text async");
                Console.WriteLine("some text");
                Thread.Sleep(3000);
            }
        }

        static async Task GetFilesAsync2()
        {
            await SomeWorkload();
            string path = @"C:\Users\gzms\Desktop";
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);
            string[] combined = files.Concat(directories).ToArray();
        }



    }
}