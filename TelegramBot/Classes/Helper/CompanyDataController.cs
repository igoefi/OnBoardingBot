using System.Collections.Generic;
using TelegramBot.Classes.JSON;

namespace TelegramBot.Classes.Helper
{
    public abstract class CompanyDataController
    {
        public static User FindUserByID(long chatID)
        {
            var users = CompanyProfile.Data.Users;
            foreach (User user in users)
            {
                if (user.ChatID == chatID)
                    return user;
            }
            return null;
        }

        public static User FindUserByCode(string code)
        {
            List<User> users = CompanyProfile.Data.Users;
            foreach (User user in users)
            {
                if (user.Code == code)
                    return user;
            }
            return null;
        }

        public static Part GetEducationPart(string speciality, int part)
        {
            var educParts = CompanyProfile.Data.EducationParts;
            if (educParts == null) return null;

            educParts.TryGetValue(speciality, out List<Part> partsList);
            if (partsList == null) return null;

            if (partsList.Count < part) return null;
            return partsList[part];
        }

        public static string GetToken() =>
            CompanyProfile.Data.Token;

        public static string GetCompanyName() =>
            CompanyProfile.Data.CompanyName;
        public static string GetCompanyInfo() =>
            CompanyProfile.Data.CompanyInfo;

        public static Dictionary<string, string> GetSpecialWords() =>
            CompanyProfile.Data.SpecialWords;

        public static List<Product> GetProduct() =>
            CompanyProfile.Data.Products;

        public static Dictionary<string, List<Employee>> GetEmployees() =>
            CompanyProfile.Data.Eployees;
    }
}
