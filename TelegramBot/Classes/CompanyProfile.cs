using System;
using System.Collections.Generic;
using TelegramBot.Classes.JSON;

namespace TelegramBot.Classes
{
    [Serializable]
    public static class CompanyProfile
    {
        public static string Token { get; set; }
        public static string CompanyName { get; set; }
        public static Dictionary<string, string> SpecialWords { get; set; }
        public static List<User> Users { get; set; }
        public static Dictionary<string, List<Employee>> Eployees { get; set; }
        public static List<Product> Products { get; set; }
        public static Dictionary<string, List<Part>> EducationParts { get; set; }
    }
}
