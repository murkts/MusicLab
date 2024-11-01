using System;
using System.Collections.Generic;
using System.Linq;
using MusicLab.Models;

namespace MusicLab.Services
{
    public class MusicSearch
    {
        private readonly List<Artist> _artists;
        private readonly List<Album> _albums;
        private readonly List<Compilation> _compilations;

        public MusicSearch(List<Artist> artists, List<Album> albums, List<Compilation> compilations)
        {
            _artists = artists;
            _albums = albums;
            _compilations = compilations;
        }

        public IEnumerable<Artist> SearchArtists(string name) =>
            _artists.Where(artist => artist.Name.Contains(name, StringComparison.OrdinalIgnoreCase));

        public IEnumerable<Album> SearchAlbums(string title) =>
            _albums.Where(album => album.Title.Contains(title, StringComparison.OrdinalIgnoreCase));

        public IEnumerable<Compilation> SearchCompilations(string title) =>
            _compilations.Where(comp => comp.Title.Contains(title, StringComparison.OrdinalIgnoreCase));

        public IEnumerable<Track> SearchTracks(string title = null, string genre = null, string artistName = null)
        {
            return _artists.SelectMany(artist => artist.Albums)
                .SelectMany(album => album.Tracks)
                .Where(track =>
                    (string.IsNullOrEmpty(title) || track.Title.Contains(title, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(genre) || track.Genre.Name.Equals(genre, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(artistName) || track.Artist.Name.Equals(artistName, StringComparison.OrdinalIgnoreCase))
                );
        }
    }
}