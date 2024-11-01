using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using MusicLab.Models;

namespace MusicLab.Data
{
    public static class DataStorage
    {
        private const string DataFilePath = "catalog_data.json";

        public static void SaveData(List<Artist> artists, List<Album> albums, List<Compilation> compilations)
        {
            var data = new { Artists = artists, Albums = albums, Compilations = compilations };
            var json = JsonSerializer.Serialize(data);
            File.WriteAllText(DataFilePath, json);
        }

        public static (List<Artist>, List<Album>, List<Compilation>) LoadData()
        {
            if (!File.Exists(DataFilePath)) return (new List<Artist>(), new List<Album>(), new List<Compilation>());
            
            var json = File.ReadAllText(DataFilePath);
            var data = JsonSerializer.Deserialize<DataContainer>(json);

            return (data.Artists, data.Albums, data.Compilations);
        }

        private class DataContainer
        {
            public List<Artist> Artists { get; set; }
            public List<Album> Albums { get; set; }
            public List<Compilation> Compilations { get; set; }
        }
    }
}