using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MusicLab.Models;
using MusicLab.Services;
using MusicLab.Data;

namespace MusicLab.Views
{
    public partial class MainForm : Form
    {
        private List<Artist> artists = new List<Artist>();
        private List<Album> albums = new List<Album>();
        private List<Compilation> compilations = new List<Compilation>();
        private MusicSearch musicSearch;

        public MainForm()
        {
            InitializeComponent();
            LoadData();
            musicSearch = new MusicSearch(artists, albums, compilations);
            cbSearchType.Items.AddRange(new[] { "Артист", "Альбом", "Сборник", "Трек" });
            cbSearchType.SelectedIndex = 0;
        }

        private void LoadData()
        {
            (artists, albums, compilations) = DataStorage.LoadData();
        }

        private void SaveData()
        {
            DataStorage.SaveData(artists, albums, compilations);
            MessageBox.Show("Данные сохранены успешно.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbResults.Items.Clear();
            string query = tbSearch.Text.Trim();
            string searchType = cbSearchType.SelectedItem.ToString();
            
            switch (searchType)
            {
                case "Артист":
                    var artistResults = musicSearch.SearchArtists(query);
                    foreach (var artist in artistResults) lbResults.Items.Add($"Артист: {artist.Name}");
                    break;
                case "Альбом":
                    var albumResults = musicSearch.SearchAlbums(query);
                    foreach (var album in albumResults) lbResults.Items.Add($"Альбом: {album.Title} - {album.Artist.Name}");
                    break;
                case "Сборник":
                    var compilationResults = musicSearch.SearchCompilations(query);
                    foreach (var comp in compilationResults) lbResults.Items.Add($"Сборник: {comp.Title}");
                    break;
                case "Трек":
                    var trackResults = musicSearch.SearchTracks(query);
                    foreach (var track in trackResults) lbResults.Items.Add($"Трек: {track.Title} - {track.Artist.Name} ({track.Genre.Name})");
                    break;
            }
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            string artistName = Prompt.ShowDialog("Введите имя артиста:", "Добавить артиста");
            if (!string.IsNullOrEmpty(artistName))
            {
                artists.Add(new Artist(artistName));
                MessageBox.Show($"Артист {artistName} добавлен.");
            }
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            string artistName = Prompt.ShowDialog("Введите имя артиста:", "Добавить альбом");
            var artist = artists.FirstOrDefault(a => a.Name == artistName);
            if (artist != null)
            {
                string albumTitle = Prompt.ShowDialog("Введите название альбома:", "Добавить альбом");
                int releaseYear = int.Parse(Prompt.ShowDialog("Введите год выпуска альбома:", "Добавить альбом"));
                var album = new Album(albumTitle, releaseYear, artist);
                artist.Albums.Add(album);
                albums.Add(album); 
        
                MessageBox.Show($"Альбом {albumTitle} добавлен для артиста {artistName}.");
            }
            else
            {
                MessageBox.Show("Артист не найден.");
            }
        }


        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            string albumTitle = Prompt.ShowDialog("Введите название альбома:", "Добавить трек");
            var album = albums.FirstOrDefault(a => a.Title == albumTitle);
            if (album != null)
            {
                string trackTitle = Prompt.ShowDialog("Введите название трека:", "Добавить трек");
                TimeSpan duration = TimeSpan.Parse(Prompt.ShowDialog("Введите длительность трека (мм:сс):", "Добавить трек"));
                string genreName = Prompt.ShowDialog("Введите жанр трека:", "Добавить трек");
                var genre = new Genre(genreName);
                var track = new Track(trackTitle, duration, genre, album.Artist);
                album.Tracks.Add(track);
                MessageBox.Show($"Трек {trackTitle} добавлен в альбом {albumTitle}.");
            }
            else
            {
                MessageBox.Show("Альбом не найден.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e) => SaveData();
    }
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form() { Width = 300, Height = 150, Text = caption };
            Label label = new Label() { Left = 10, Top = 10, Text = text };
            TextBox textBox = new TextBox() { Left = 10, Top = 40, Width = 250 };
            Button confirmation = new Button() { Text = "OK", Left = 100, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(label);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.ShowDialog();
            return textBox.Text;
        }
    }
}
