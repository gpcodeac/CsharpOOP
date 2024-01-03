using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture208.Classes
{
    internal class TestClass
    {
        public string Text { get; set; }
        public int Number { get; set; }

        public TestClass()
        {

        }
        public TestClass(string text, int number)
        {
            Text = text;
            Number = number;
        }
        public void Test1()
        {
            Console.WriteLine("Test1");
        }

        public override string ToString()
        {
            return $"Text: {Text}, Number: {Number}";
        }
    }
}
