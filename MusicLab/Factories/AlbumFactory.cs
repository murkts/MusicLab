using System.Collections.Generic;
using MusicLab.Models;

namespace MusicLab.Factories
{
    public static class AlbumFactory
    {
        public static Album CreateAlbum(string title, int releaseYear, Artist artist, List<Track> tracks)
        {
            var album = new Album(title, releaseYear, artist);
            album.Tracks.AddRange(tracks);
            return album;
        }
    }
}