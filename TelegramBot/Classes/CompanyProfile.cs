using System;
using System.IO;
using TelegramBot.Classes.Helper;

namespace TelegramBot.Classes
{
    [Serializable]
    public static class CompanyProfile
    {
        private static readonly string _filePath = Path.Combine(Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName, "Roaming", "df.txt");
        public static CompanyData Data { get; private set; }

        public static void SaveData()
        {
            if (File.Exists(_filePath))
                File.Delete(_filePath);
            JSONSerializeController.SerializeObject(Data, _filePath);
        }

        public static void ReadData(CompanyData data) =>
            Data = data;
    }
}
