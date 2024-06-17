# 🏎️RaceWinFormsApp
Копия игры «Race» (оригинал: [RaceGame](https://github.com/Fruktozec/RaceGame)), созданной в процессе изучения технологии Windows Forms, принципов ООП, работы со звуком, регулярными выражениями и шифрованием данных с хранением в JSON.
<div " align="center">

![image](https://github.com/IvanPovaliaev/RaceWinFormsApp/assets/157638990/f5b3651e-7983-48f0-bdef-f5ba675bfc03)

</div>

## 📝Описание работы

### 🏆Цель игры
Цель - набрать как можно больше очков и монет.

### 📜Привила игры
1. Управление машиной осуществляется с помощью стрелок на клавиатуре:
    * Стрелками `←` и `→` осуществляется движение машины `налево` и `направо` соответственно.
    * При нажатии на `↑` скорость движения машины игрока `увеличивается`;
    * При нажатии на `↓` скорость движения машины игрока `уменьшается` вплоть до полной остановки;
2.  При выезде за край карты, машина появляется с противоположной стороны.
3. Скорость начисления очков зависит от скорости машины игрока. При полной остановке очки перестают начисляться.
4. При столкновении со встречной машиной возможны следующие варианты:
    * Если у игрока имеется `15` монет, то имеется возможность `продолжить` игру, заплатив данную сумму;
    * Если у игрока `отсуствует` необходимая сумма или игрок `отказался` от платы, игра `заканчивается`.

### ⚙️Настройки
В настроках можно изменить громкость фоновой музыки и громкость игровых звуков. Данные настройки сохраняются после выхода из приложения.

### 📊Результаты
В результатах можно посмотреть информация о резельтатах предыдущих игроков: ***имя, счёт, количество монет, дату игры***.

### ⏸️Пауза
Игру можно поставить на паузу 2 способами:
1. Нажав на кнопку `Pause` в левом нижнем углу окна;
2. Нажав клавишу `ESC`.

В меню паузы имеется 2 варианта:
1. Продолжить игру (`Resume`)
2. Выйти в главное меню (`Exit`)


### 🕹️Геймплей

## 🛠️Техническая часть

Проект выполнен с соблюдением принципов `ООП` и использованием `LINQ`.
Хранение результатов осуществляется в отдельных файлах файловой системы с сериализацией/дисериализацией в `JSON` с использованием библиотеки `Newtonsoft.Json`.

### 🏗️Архитектура

Структура каталога решения:<br />
  
 ![image](https://github.com/IvanPovaliaev/RaceWinFormsApp/assets/157638990/b126ea81-2e7e-4ba7-9e3f-cd685a0db5a9)

### 🎶Работа со звуком
Для работы со звуком была использована библиотека `NAudio`. Работа со звуком осуществляется с помощью статического класса `AudioProvider`:
```csharp
public static class AudioProvider
{
    public async static Task PlayBGMAsync(string bgmDirectoryPath)
    {
        await Task.Run(() =>
        {
            var audioIndex = 0;
            var directoryInfo = new DirectoryInfo(bgmDirectoryPath);
            var audiosPaths = new List<string>();

            foreach (var file in directoryInfo.GetFiles("*.wav", SearchOption.TopDirectoryOnly))
                audiosPaths.Add(file.FullName.ToString());

            audiosPaths = audiosPaths.Shuffle().ToList();

            StaticData.BGMPlayer = new WaveOutEvent();
            
            var audioFileReader = new AudioFileReader(audiosPaths[0]);

            StaticData.BGMPlayer.Init(audioFileReader);
            StaticData.BGMPlayer.Volume = SystemSettings.BGMVolume / 100f;

            StaticData.BGMPlayer.DeviceNumber = 0;

            StaticData.BGMPlayer.PlaybackStopped += (sender, e) =>
            {
                audioFileReader.Dispose();

                if (audioIndex + 1 == audiosPaths.Count)
                {
                    audiosPaths = audiosPaths.Shuffle().ToList();
                    audioIndex = 0;
                }
                else audioIndex++;

                audioFileReader = new AudioFileReader(audiosPaths[audioIndex]);
                StaticData.BGMPlayer.Init(audioFileReader);
                StaticData.BGMPlayer.Play();
            };

            StaticData.BGMPlayer.Play();
        });
    }
    public async static Task PlaySoundAsync(string audiofilePath)
    {
        await Task.Run(() =>
        {
            var audioFileReader = new AudioFileReader(audiofilePath);
            var waveChannel = new WaveChannel32(audioFileReader);
            waveChannel.Volume = SystemSettings.SoundsVolume / 100f;

            var player = new DirectSoundOut();
            player.Init(waveChannel);
            player.Play();
            player.PlaybackStopped += (sender, e) =>
            {
                audioFileReader.Dispose();
                waveChannel.Dispose();
                player.Dispose();
            };
        });
    }
}
```

### 🔐Шифрование данных
Для организации шифрования данных используется класс `AESEncryptionProvider`. Для шифрования данных используется симметричный алгоритм `AES`.
```csharp
public static class AESEncryptionProvider
{
    private static string keysPath = @"aesKeys.dat";

    /// <summary>
    /// Encrypt string via AES algorithm
    /// </summary>
    public static string EncryptString(string originalString)
    {
        using (var aes = Aes.Create())
        {
            aes.Key = GetKeys(out var aesIV);
            aes.IV = aesIV;
            var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            
            using (var msEncrypt = new MemoryStream())
            {
                using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                using (var swEncrypt = new StreamWriter(csEncrypt))
                {
                    swEncrypt.Write(originalString);
                }
                return Convert.ToBase64String(msEncrypt.ToArray());
            }
        }
    }
    /// <summary>
    /// Decrypt string via AES algorithm
    /// </summary>
    public static string DecryptString(string decryptedString)
    {
        var cipherText = Convert.FromBase64String(decryptedString);
        using (var aes = Aes.Create())
        {
            aes.Key = GetKeys(out var aesIV);
            aes.IV = aesIV;
            var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using (var msDecrypt = new MemoryStream(cipherText))
            using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
            using (var reader = new StreamReader(csDecrypt))
            {
                return reader.ReadToEnd();
            }
        }
    }
    /// <summary>
    /// Get AES keys
    /// </summary>
    private static byte[] GetKeys(out byte[] aesIV)
    {
        byte[] aesKey;

        if (!FileProvider.Exists(keysPath))
        {
            using (var aes = Aes.Create())
            {
                aes.GenerateKey();
                aes.GenerateIV();

                aesKey = aes.Key;
                aesIV = aes.IV;

                FileProvider.Save(keysPath, $"{Convert.ToBase64String(aesKey)}\n{Convert.ToBase64String(aesIV)}");
            }
            return aesKey;
        }

        var aesFile = FileProvider.GetContent(keysPath).Split("\n");

        aesKey = Convert.FromBase64String(aesFile[0]);
        aesIV = Convert.FromBase64String(aesFile[1]);            
        return aesKey;
    }
}
```

### 🔄Сериализация зашифрованных данных
Для сериализации/десериализации зашифрованных JSON-файлов используется класс `JsonProvider`
```csharp
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
        return AESEncryptionProvider.EncryptString(jsonData);
    }
}
```
