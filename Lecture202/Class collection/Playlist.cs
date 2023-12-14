using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture202.Class_collection
{
    internal class Playlist
    {
        public Playlist() { }

        public Playlist(string genre, string title)
        {
            Genre = genre;
            Title = title;
        }

        public string Genre { get; set; }
        public string Title { get; set; }
        public List<Song> SongList { get; set; } = new();

        public void AddSong(Song song)
        {
            SongList.Add(song);
        }

        public void RemoveSong(Song song)
        {
            SongList.Remove(song);
        }

    }
}
