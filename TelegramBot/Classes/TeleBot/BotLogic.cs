using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.Classes;
using TelegramBot.Classes.Helper;

namespace TelegramBot
{
    public class BotLogic
    {
        private static TelegramBotClient _client;
        private static CancellationToken _token;

        public static bool IsTokenCorrect(string token)
        {
            try
            {
                _client = new TelegramBotClient(token);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void StartBot(string token) =>
            Start(token);

        private static void Start(string token)
        {
            _client = new TelegramBotClient(token);
            _client.StartReceiving(Upd, Error);
        }

        async static private Task Upd(ITelegramBotClient client, Update update, CancellationToken token)
        {
            _token = token;

            Message message = update.Message;
            CallbackQuery result = update.CallbackQuery;

            if (message != null)
            {
                Classes.JSON.User user = CompanyDataController.FindUserByID(message.Chat.Id);
                if (user == null)
                {
                    if (message.Text == "/start")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, CompanyProfile.Data.SpecialWords["/start"], cancellationToken: token);
                    }
                    else
                    {
                        Classes.JSON.User userByCode = CompanyDataController.FindUserByCode(message.Text);
                        if (userByCode != null)
                            if (userByCode.ChatID != default)
                                user.SetChatID(message.Chat.Id);
                            else
                                await client.SendTextMessageAsync(message.Chat.Id, "Этим кодом уже воспользовались", cancellationToken: token);
                        else
                            await client.SendTextMessageAsync(message.Chat.Id, "Некорреектный код", cancellationToken: token);
                    }
                    return;
                }

                if (user.SelectedVictorine == null)
                {
                    var words = CompanyProfile.Data.SpecialWords;
                    foreach (string word in words.Keys)
                        if (message.Text.ToLower() == word.ToLower())
                            await client.SendTextMessageAsync(message.Chat.Id, words[word], cancellationToken: token);
                }
                else
                {
                    string res = user.SetAnswer(message.Text);
                    if(res != null)
                        await client.SendTextMessageAsync(message.Chat.Id, res, cancellationToken: token);
                    else
                        await client.SendTextMessageAsync(message.Chat.Id, user.GetActualQuestion(), cancellationToken: token);
                }
            }
            else if (result != null)
            {
                Enum.TryParse(result.Data, out DataEnum resultEnum);
                if (resultEnum == default)
                    return;

                var user = CompanyDataController.FindUserByID(message.Chat.Id);
                if (user == null) return;

                switch (resultEnum)
                {
                    case DataEnum.StartTest:
                        var part = CompanyDataController.GetEducationPart(user.Speciality, user.SelectedChapter);
                        if (part == null) return;

                        user.SetVictorine(part);

                        break;

                    case DataEnum.StartNewChapter:
                        user.SelectedChapter++;

                        var selectedPart = CompanyDataController.GetEducationPart(user.Speciality, user.SelectedChapter);
                        if (selectedPart == null) return;

                        await client.SendTextMessageAsync(message.Chat.Id, selectedPart.Theory, cancellationToken: token);

                        break;
                }

            }
        }



        private static Task Error(ITelegramBotClient arg1, Exception exception, CancellationToken arg3)
        {
            MessageBox.Show("Произошла ошибка при работе бота. Подробнее:" + exception.Message.ToString());

            return null;
        }
    }
}