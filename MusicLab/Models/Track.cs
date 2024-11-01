using System;

namespace MusicLab.Models
{
    public class Track
    {
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; }

        public Track(string title, TimeSpan duration, Genre genre, Artist artist)
        {
            Title = title;
            Duration = duration;
            Genre = genre;
            Artist = artist;
        }
    }
}