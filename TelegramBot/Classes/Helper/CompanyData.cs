using System.Collections.Generic;
using TelegramBot.Classes.JSON;

namespace TelegramBot.Classes.Helper
{
    public class CompanyData
    {
        public string Token { get; set; }
        public string CompanyName { get; set; }
        public string CompanyInfo { get; set; }
        public Dictionary<string, string> SpecialWords { get; set; }
        public List<User> Users { get; set; }
        public List<Product> Products { get; set; }
        public Dictionary<string, List<Employee>> Eployees { get; set; }
        public Dictionary<string, List<Part>> EducationParts { get; set; }
    }
}