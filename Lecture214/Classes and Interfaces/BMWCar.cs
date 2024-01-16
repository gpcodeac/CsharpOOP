using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture214.Classes_and_Interfaces
{
    internal class BMWCar : Car
    {
        private bool _isXDrive;
        public bool IsXDrive
        {
            get { return _isXDrive; }
            set { _isXDrive = value; }
        }
        public BMWCar(string model = "", double fuel = 0.0d) : base(model, fuel)
        {
        }


    }
}
