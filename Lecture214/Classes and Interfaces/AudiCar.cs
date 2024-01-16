using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture214.Classes_and_Interfaces
{
    internal class AudiCar :Car
    {
        private bool _isQuattro;
        public bool IsQuattro
        {
            get { return _isQuattro; }
            set { _isQuattro = value; }
        }
        public AudiCar(string model = "", double fuel = 0.0d) : base(model, fuel)
        {
        }
    }
}
