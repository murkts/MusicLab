using System;
using MusicLab.Models;

namespace MusicLab.Factories
{
    public static class TrackFactory
    {
        public static Track CreateTrack(string title, TimeSpan duration, Genre genre, Artist artist)
        {
            return new Track(title, duration, genre, artist);
        }
    }
}