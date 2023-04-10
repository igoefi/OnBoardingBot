using TelegramBot.Classes.JSON;

namespace TelegramBot.Classes.Helper
{
    public static class UserHelper
    {
        public static User FindUserByID(long chatID)
        {
            var users = CompanyProfile.Users;
            foreach (var user in users)
            {
                if (user.ChatID == chatID)
                    return user;
            }
            return null;
        }
        public static User FindUserByCode(string code)
        {
            var users = CompanyProfile.Users;
            foreach (var user in users)
            {
                if (user.Code == code)
                    return user;
            }
            return null;
        }
    }
}
