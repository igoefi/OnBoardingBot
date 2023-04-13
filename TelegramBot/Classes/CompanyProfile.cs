using System;
using System.IO;
using TelegramBot.Classes.Helper;

namespace TelegramBot.Classes
{
    [Serializable]
    public static class CompanyProfile
    {

        public static CompanyData Data { get; private set; } = new CompanyData();

        public static void SaveData()
        {
            var filePath = PathFile.PathFileStr;
            if (File.Exists(filePath))
                File.Delete(filePath);
            JSONSerializeController.SerializeObject(Data, filePath);
        }

        public static void ReadData(CompanyData data) =>
            Data = data;

        public static void FirstStart(string name, string about, string token, string answer)
        {
            Data.CompanyName = name;
            Data.CompanyInfo = about;
            Data.Token = token;
            Data.SpecialWords.Add("/start", answer);
        }

        public static void DeleteEmployee(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return;

            foreach(var specialization in Data.Eployees.Keys)
            {
                foreach(var employee in Data.Eployees[specialization])
                {
                    if(employee.FullName == name)
                    {
                        Data.Eployees[specialization].Remove(employee);
                        return;
                    }
                }
            }
        }
    }
}
