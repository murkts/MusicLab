using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using MusicLab.Models;

namespace MusicLab.Data
{
    public static class DataStorage
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.json");

        public static void SaveData(List<Artist> artists, List<Album> albums, List<Compilation> compilations)
        {
            try
            {
                var data = new { Artists = artists, Albums = albums, Compilations = compilations };

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true, // Для читаемости JSON
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase // Имена свойств в стиле camelCase
                };

                var json = JsonSerializer.Serialize(data, options);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при сохранении данных: {ex.Message}", ex);
            }
        }

        public static (List<Artist>, List<Album>, List<Compilation>) LoadData()
        {
            if (!File.Exists(FilePath)) return (new List<Artist>(), new List<Album>(), new List<Compilation>());

            try
            {
                var json = File.ReadAllText(FilePath);
                var data = JsonSerializer.Deserialize<DataContainer>(json);

                return (data.Artists ?? new List<Artist>(),
                        data.Albums ?? new List<Album>(),
                        data.Compilations ?? new List<Compilation>());
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при загрузке данных: {ex.Message}", ex);
            }
        }

        private class DataContainer
        {
            public List<Artist> Artists { get; set; }
            public List<Album> Albums { get; set; }
            public List<Compilation> Compilations { get; set; }
        }
    }
}
