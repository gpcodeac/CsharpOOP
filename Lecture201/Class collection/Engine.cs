using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture201
{
    internal class Engine
    {
        public Engine() { }

        public void Start()
        {
            Running = true;
        }
        public void Stop()
        {
            Running = false;
        }
        public double Capacity {  get; set; }
        public string FuelType { get; set; }
        public bool Running {  get; private set; }
    }
}
