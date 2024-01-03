using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture208.Classes
{
    internal abstract class Sport
    {
        private string _name;
        private string _season;
        private bool _isOlympic;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Season
        {
            get { return _season; }
            set
            {
                if (value == "Summer" || value == "Winter")
                {
                    _season = value;
                }
                else
                {
                    Console.WriteLine("Invalid season.");
                }
            }
        }
        public bool IsOlympic
        {
            get { return _isOlympic; }
            set { _isOlympic = value; }
        }


        public Sport()
        {
        }

        public Sport(string name, string season, bool isOlympic)
        {
            Name = name;
            Season = season;
            IsOlympic = isOlympic;
        }
    }
}
