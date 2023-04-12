using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot.Classes.Helper
{
    public abstract class PathFile
    {
        public static string PathFileStr { get; private set; } = Path.Combine(Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName, "Roaming", "df.txt");
    }
}
