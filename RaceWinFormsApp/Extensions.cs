using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace RaceWinFormsApp
{
    public static class Extensions
    {
        /// <summary>
        /// Рандомно перемешивает элементы текущей коллекции
        /// </summary>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> array)
        {
            var List = array.ToList();

            for (int i = 0; i < List.Count; i++)
            {
                var randomIndex = new Random().Next(0, List.Count - 1);
                (List[i], List[randomIndex]) = (List[randomIndex], List[i]);
            }

            return List;
        }
        public static void OpenCreatedFile(this string path)
        {
            var process = new Process();
            var startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            var file = new FileInfo(path);
            startInfo.UseShellExecute = true;
            startInfo.FileName = file.FullName;
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
