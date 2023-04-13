using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBot.Classes;
using TelegramBot.Classes.Helper;
using TelegramBot.Classes.JSON;

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
                        var userByCode = CompanyDataController.FindUserByCode(message.Text);
                        if (userByCode != null)
                            if (userByCode.ChatID == 0)
                            {
                                userByCode.SetChatID(message.Chat.Id);
                                await client.SendTextMessageAsync(message.Chat.Id, "Код принят", cancellationToken: _token);

                                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                                    {
                                        new[]
                                        {
                                            InlineKeyboardButton.WithCallbackData("О компании", DataEnum.GetCompanyInfo.ToString()),
                                            InlineKeyboardButton.WithCallbackData("Сотрудники", DataEnum.GetEmployees.ToString())
                                        },
                                        new[]
                                        {
                                            InlineKeyboardButton.WithCallbackData("Обучение", DataEnum.Education.ToString())
                                        }
                                    });
                                await client.SendTextMessageAsync(message.Chat.Id, "Действие", replyMarkup: inlineKeyboard, cancellationToken: _token);
                            }
                            else if (userByCode.SelectedVictorine == null)
                                await client.SendTextMessageAsync(message.Chat.Id, "Этим кодом уже воспользовались", cancellationToken: token);
                            else
                                await client.SendTextMessageAsync(message.Chat.Id, "Некорреектный код", cancellationToken: token);
                    }
                    return;
                }
                else if (user.SelectedVictorine != null)
                {
                    var res = user.SetAnswer(message.Text);
                    if (res != null)
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, res, cancellationToken: token);
                        var inlineKeyboard = new InlineKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData("О компании", DataEnum.GetCompanyInfo.ToString()),
                                InlineKeyboardButton.WithCallbackData("Сотрудники", DataEnum.GetEmployees.ToString())
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData("Обучение", DataEnum.Education.ToString())
                            }
                        });

                        await client.SendTextMessageAsync(message.Chat.Id, "Действие", replyMarkup: inlineKeyboard, cancellationToken: _token);
                    }
                    else
                        await client.SendTextMessageAsync(message.Chat.Id, user.GetActualQuestion(), cancellationToken: token);
                }
                else
                {
                    var words = CompanyProfile.Data.SpecialWords;
                    foreach (string word in words.Keys)
                        if (message.Text.ToLower() == word.ToLower())
                            await client.SendTextMessageAsync(message.Chat.Id, words[word], cancellationToken: token);

                }
            }
            else if (result != null)
            {
                if (!Enum.TryParse(result.Data, out DataEnum resultEnum))
                    return;

                var chatId = result.Message.Chat.Id;

                var user = CompanyDataController.FindUserByID(chatId);
                if (user == null) return;
                InlineKeyboardMarkup inlineKeyboard;

                switch (resultEnum)
                {
                    case DataEnum.StartTest:
                        var part = CompanyDataController.GetEducationPart(user.Speciality, user.SelectedChapter);
                        if (part == null) return;

                        user.SetVictorine(part);
                        await client.SendTextMessageAsync(chatId, user.GetActualQuestion(), cancellationToken: token);
                        break;

                    case DataEnum.Education:
                        if (user.IsEndedTest)
                            user.SelectedChapter++;
                        user.IsEndedTest = false;

                        var selectedPart = CompanyDataController.GetEducationPart(user.Speciality, user.SelectedChapter);
                        if (selectedPart == null)
                        {
                            await client.SendTextMessageAsync(chatId, "Уроков больше нет", cancellationToken: token);
                            return;
                        }

                        await client.SendTextMessageAsync(chatId, selectedPart.Theory, cancellationToken: token);

                        inlineKeyboard = new InlineKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData("Начать тест", DataEnum.StartTest.ToString())
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData("В главное меню", DataEnum.GoToMain.ToString())
                            }
                        });

                        await client.SendTextMessageAsync(chatId, "Действие", replyMarkup: inlineKeyboard, cancellationToken: _token);
                        break;

                    case DataEnum.GetCompanyInfo:
                        await client.SendTextMessageAsync(chatId, CompanyDataController.GetCompanyName(), cancellationToken: token);
                        await client.SendTextMessageAsync(chatId, CompanyDataController.GetCompanyInfo(), cancellationToken: token);

                        await client.SendTextMessageAsync(chatId, "Действие",
                            replyMarkup: new InlineKeyboardMarkup(new[] { InlineKeyboardButton.WithCallbackData("В главное меню", DataEnum.GoToMain.ToString()) }), cancellationToken: _token);
                        break;

                    case DataEnum.GetEmployees:
                        string needMessage = string.Empty;

                        var allEmployees = CompanyDataController.GetEmployees();
                        if (allEmployees == null || allEmployees.Count == 0) return;

                        allEmployees.TryGetValue(user.Speciality, out List<Employee> employees);
                        if (employees == null || employees.Count == 0) return;
                        foreach (var employee in employees)
                        {
                            string employeeText = string.Empty;
                            employeeText += employee.FullName + "\n";
                            employeeText += employee.Description + "\n";
                            employeeText += "Emai: " + employee.Email + "\n";
                            needMessage += employeeText + "\n";
                        }

                        await client.SendTextMessageAsync(chatId, needMessage, cancellationToken: token);

                        await client.SendTextMessageAsync(chatId, "Действие",
                            replyMarkup: new InlineKeyboardMarkup(new[] { InlineKeyboardButton.WithCallbackData("В главное меню", DataEnum.GoToMain.ToString()) }), cancellationToken: _token);
                        break;

                    case DataEnum.GoToMain:
                        inlineKeyboard = new InlineKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData("О компании", DataEnum.GetCompanyInfo.ToString()),
                                InlineKeyboardButton.WithCallbackData("Сотрудники", DataEnum.GetEmployees.ToString())
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData("Обучение", DataEnum.Education.ToString())
                            }
                        });

                        await client.SendTextMessageAsync(chatId, "Действие", replyMarkup: inlineKeyboard, cancellationToken: _token);
                        break;
                }
            }
        }

        private static Task Error(ITelegramBotClient arg1, Exception exception, CancellationToken arg3)
        {
            throw exception;
        }
    }
}