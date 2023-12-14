using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture202.Class_collection
{
    internal class Movie
    {
        public Movie() { }
        public Movie(string title, string genre) {
            Title = title;
            Genre = genre;
        }

        public string Title {  get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        private List<int> Ratings { get; set; } = new();

        public void Rate(int rating)
        {
            Ratings.Add(rating);
        }

        public bool Recommended()
        {
            double avgRating = Ratings.Average();
            if (avgRating > 5)
            {
                return true;
            }
            return false;
        }

    }
}
