using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture208.Classes
{
    internal abstract class Football : Sport
    {
        public bool IsBallSport { get; set; }
        public bool IsOutdoor { get; set; }
        public string Federation { get; set; } = "FIFA";

        public Football()
        {
        }

        public Football(string name, string season, bool isOlympic, bool isBallSport, bool isOutdoor, string federation) : base(name, season, isOlympic)
        {
            IsBallSport = isBallSport;
            IsOutdoor = isOutdoor;
            Federation = federation;
        }
    }
}
