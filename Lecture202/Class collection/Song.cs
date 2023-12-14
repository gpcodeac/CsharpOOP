using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture202.Class_collection
{
    internal class Song
    {
        public Song() { }
        public Song(string name, string artist, string album, int duration, string genre)
        {
            Name = name;
            Artist = artist;
            Album = album;
            Duration = duration;
            Genre = genre;
        }

        public string Name { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Duration { get; set; }
        public string Genre { get; set; }

    }
}
