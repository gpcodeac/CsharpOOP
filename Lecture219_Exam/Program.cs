namespace Lecture219_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            while(true)
            {
                POSSystem pOSSystem = new();
                pOSSystem.Run();
            }
        }

        

    }
}