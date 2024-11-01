using System.Collections.Generic;

namespace MusicLab.Models
{
    public class Artist
    {
        public string Name { get; set; }
        public List<Album> Albums { get; set; } = new List<Album>();

        public Artist(string name)
        {
            Name = name;
        }
    }
}