using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBot.Classes.Helper;
using File = System.IO.File;

namespace TelegramBot
{
    public class BotLogic
    {
        private static TelegramBotClient _client;
        private static CancellationToken _token;

        private const string _recomendationInError = "Советую грязно оскорбить разработчиков в уме";

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
            //Ужаснейший костыль, но время жестоко
            _token = token;

            var message = update.Message;
            var result = update.CallbackQuery;
            if (message != null)
                switch (message.Text)
                {
                    case "/start":
                        await client.SendTextMessageAsync(message.Chat.Id, "Привет, я нейро-бот твоей мечты. " +
                            "Я умею синтезировать прекрасные голосовые, так что могу заменить тебе реальных людишек", cancellationToken: token);
                        break;

                    case "/help":
                        await client.SendTextMessageAsync(message.Chat.Id, "Напишите /voice " +
                            "чтобы просмотреть мою прекрасную коллекцию голосов. Или же /sub, чтобы подписаться на уведомления МГОК-а", cancellationToken: token);
                        break;

                    default:
                        
                        break;
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