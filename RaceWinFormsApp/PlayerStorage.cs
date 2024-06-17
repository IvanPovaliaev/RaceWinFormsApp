using Newtonsoft.Json;
using System.Collections.Generic;

namespace RaceWinFormsApp
{
    public static class PlayerStorage
    {
        private static string filePath { get; } = @".\data\Leaderboard.json";
        public static List<Player> GetAll()
        {
            if (!FileProvider.Exists(filePath) || FileProvider.GetContent(filePath) == string.Empty)
            {
                return new List<Player>();
            }

            var fileData = FileProvider.GetContent(filePath);
            var userResults = JsonConvert.DeserializeObject<List<Player>>(fileData);
            return userResults;
        }
        public static void Save(Player user)
        {
            var usersResults = GetAll();
            usersResults.Add(user);
            FileProvider.Save(filePath, usersResults);
        }
        public static void Clear() => FileProvider.Clear(filePath);        
    }
}
