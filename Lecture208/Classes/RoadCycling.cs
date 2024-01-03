using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture208.Classes
{
    internal abstract class RoadCycling : Sport
    {
        public bool IsBallSport { get; set; }
        public bool IsOutdoor { get; set; }
        public string Federation { get; set; } = "UCI";

        public RoadCycling()
        {
        }

        public RoadCycling(string name, string season, bool isOlympic, bool isBallSport, bool isOutdoor)
            : base(name, season, isOlympic)
        {
            IsBallSport = isBallSport;
            IsOutdoor = isOutdoor;
        }

      
    }
}
