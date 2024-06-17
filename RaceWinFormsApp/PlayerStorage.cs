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
            var userResults = JsonProvider.Deserialize<Player>(fileData);
            return userResults;
        }
        public static void Save(Player user)
        {
            var usersResults = GetAll();
            usersResults.Add(user);
            var jsonData = JsonProvider.Serialize(usersResults);
            FileProvider.Save(filePath, jsonData);
        }
        public static void Clear() => FileProvider.Clear(filePath);        
    }
}
