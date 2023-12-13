using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture201
{
    internal class Car
    {
        public Car()
        {
            Engine = new Engine();
        }

        public void StartEngine()
        {
            Engine.Start();
        }

        public void StopEngine()
        {
            Engine.Stop();
        }

        public string ModelName { get; set; }
        public int ManufactureYear { get; set; }
        public Engine Engine { get; set; }
    }
}
