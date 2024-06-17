using Newtonsoft.Json;
using System.Collections.Generic;

namespace RaceWinFormsApp
{
    public static class JsonProvider
    {
        public static List<T>? Deserialize<T>(string encryptedJsonData)
        {
            var decryptedJsonText = AESEncryptionProvider.DecryptString(encryptedJsonData);
            return JsonConvert.DeserializeObject<List<T>>(decryptedJsonText);
        }

        public static string Serialize<T>(List<T> values)
        {
            var jsonData = JsonConvert.SerializeObject(values, Formatting.Indented);
            var encryptedJsonData = AESEncryptionProvider.EncryptString(jsonData);
            return encryptedJsonData;
        }
    }
}
