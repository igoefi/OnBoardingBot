using System;
using System.IO;
using TelegramBot.Classes.Helper;

namespace TelegramBot.Classes
{
    [Serializable]
    public static class CompanyProfile
    {
        
        public static CompanyData Data { get; private set; }

        public static void SaveData()
        {
            var filePath = PathFile.PathFileStr; 
            if (File.Exists(filePath))
                File.Delete(filePath);
            JSONSerializeController.SerializeObject(Data, filePath);
        }

        public static void ReadData(CompanyData data) =>
            Data = data;
    }
}
