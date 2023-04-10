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
            var message = update.Message;
            var result = update.CallbackQuery;
            if (message != null)
            {
                var user = UserHelper.FindUserByID(message.Chat.Id);
                if (user == null)
                {
                    if (message.Text == "/start")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, CompanyProfile.SpecialWords["/start"], cancellationToken: token);
                    }
                    else
                    {
                        var userByCode = UserHelper.FindUserByCode(message.Text);
                        if (userByCode != null)
                        {
                            if (userByCode.ChatID != default)
                                user.SetChatID(message.Chat.Id);
                            else
                                await client.SendTextMessageAsync(message.Chat.Id, "Этим кодом уже воспользовались", cancellationToken: token);
                        }
                        else
                        {
                            await client.SendTextMessageAsync(message.Chat.Id, "Некорреектный код", cancellationToken: token);
                        }
                    }
                    return;
                }

                if (user.SelectedVictorine == null)
                {
                    var words = CompanyProfile.SpecialWords;
                    foreach (var word in words.Keys)
                    {
                        if (message.Text.ToLower() == word.ToLower())
                            await client.SendTextMessageAsync(message.Chat.Id, words[word], cancellationToken: token);
                    }
                }
                else
                {
                    var res = user.SetAnswer(message.Text);
                    await client.SendTextMessageAsync(message.Chat.Id, res, cancellationToken: token);
                }
            }
            else if (result != null)
            {

            }
        }

        private static Task Error(ITelegramBotClient arg1, Exception exception, CancellationToken arg3)
        {
            MessageBox.Show("Произошла ошибка при работе бота. Подробнее:" + exception.Message.ToString());

            return null;
        }
    }
}