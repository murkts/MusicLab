using System.Collections.Generic;

namespace MusicLab.Models
{
    public class Album
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public Artist Artist { get; set; }
        public List<Track> Tracks { get; set; } = new List<Track>();

        public Album(string title, int releaseYear, Artist artist)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Artist = artist;
        }
    }
}