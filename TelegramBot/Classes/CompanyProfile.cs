using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot.Classes
{
    [Serializable]
    public static class CompanyProfile
    {
        public static string Token { get; set; }
        public static string CompanyName { get; set; }
    }
}
