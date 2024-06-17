using ClosedXML.Excel;
using System.Collections.Generic;
using System.IO;

namespace RaceWinFormsApp
{
    public static class FileProvider
    {
        private static void CreateFile(string filePath)
        {
            var dirPath = string.IsNullOrEmpty(Path.GetDirectoryName(filePath)) ? "." : Path.GetDirectoryName(filePath);
            var dirInfo = new DirectoryInfo(dirPath);
            if (!dirInfo.Exists) dirInfo.Create();
            if (!File.Exists(filePath)) File.Create(filePath).Close();
        }
        public static void Replace(string filePath, string content)
        {
            CreateFile(filePath);
            using (var sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(content);
            }
        }
        public static string GetContent(string filePath)
        {
            CreateFile(filePath);
            return File.ReadAllText(filePath, System.Text.Encoding.Default);
        }
        public static void Clear(string filePath)
        {
            if (Exists(filePath))
                File.WriteAllText(filePath, string.Empty);
        }
        public static bool Exists(string filePath) => File.Exists(filePath);
        public static void Save(string filePath, string fileData) => Replace(filePath, fileData);
        public static void ExportCollectionExcel<T>(string filePath, string sheetName, IEnumerable<T> collection)
        {
            using (var workbook = new XLWorkbook())
            {
                workbook.AddWorksheet(sheetName)
                    .FirstCell()
                    .InsertTable(collection, false);
                workbook.Worksheet(1).Row(1).Style.Font.Bold = true;
                workbook.Worksheet(1).Style.Font.FontSize = 12;
                workbook.Worksheet(1).Style.Font.FontName = "Times New Roman";
                workbook.SaveAs(filePath);
            }
        }
    }

}
