using System;
using System.IO;

namespace TelegramBot.Classes.Helper
{
    public abstract class PathFile
    {
        public static string PathFileStr { get; private set; } = Path.Combine(Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName, "Roaming", "CompanyFile.json");
    }
}
