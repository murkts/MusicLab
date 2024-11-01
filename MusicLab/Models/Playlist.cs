using System.Collections.Generic;

namespace MusicLab.Models
{
    public class Playlist
    {
        public string Name { get; set; }
        public List<Track> Tracks { get; set; } = new List<Track>();

        public Playlist(string name)
        {
            Name = name;
        }

        public void AddTrack(Track track) => Tracks.Add(track);
    }
}