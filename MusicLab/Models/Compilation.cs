using System.Collections.Generic;

namespace MusicLab.Models
{
    public class Compilation
    {
        public string Title { get; set; }
        public List<Track> Tracks { get; set; } = new List<Track>();

        public Compilation(string title, List<Track> tracks)
        {
            Title = title;
            Tracks = tracks;
        }
    }
}