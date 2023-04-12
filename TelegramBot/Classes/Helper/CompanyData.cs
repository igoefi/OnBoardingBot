using System.Collections.Generic;
using TelegramBot.Classes.JSON;

namespace TelegramBot.Classes.Helper
{
    public class CompanyData
    {
        public string Token { get; set; }
        public string CompanyName { get; set; }
        public string CompanyInfo { get; set; }
        public Dictionary<string, string> SpecialWords { get; set; } = new Dictionary<string, string>();
        public List<User> Users { get; set; } = new List<User>();
        public List<Product> Products { get; set; } = new List<Product>();
        public Dictionary<string, List<Employee>> Eployees { get; set; } = new Dictionary<string, List<Employee>>();
        public Dictionary<string, List<Part>> EducationParts { get; set; } = new Dictionary<string, List<Part>>();
    }
}