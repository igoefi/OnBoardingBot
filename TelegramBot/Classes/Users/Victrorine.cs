using System.Collections.Generic;
using System.Linq;
using System.Windows;
using TelegramBot.Classes.JSON;

namespace TelegramBot.Classes.Users
{
    public struct Victrorine
    {
        public VictorineData Data { get; private set; }
        private readonly Queue<string> _answers;
        public Victrorine(VictorineData data)
        {
            Data = data;
            _answers = new Queue<string>();
        }

        public void AddAnswer(string answer) =>
            _answers.Enqueue(answer);

        public string GetActualQuestion()
        {
            if (_answers.Count >= Data.QuestionsAnswers.Count) return null;

            var questions = Data.QuestionsAnswers.Keys.ToList();
            return questions[_answers.Count];
        }

        public int GetResultInCredits()
        {
            var quests = Data.QuestionsAnswers;

            if (_answers.Count != quests.Count)
                return -1;
            int sum = 0;
            foreach (string question in quests.Keys)
            {
                if (quests[question].ToLower() == _answers.Dequeue().ToLower())
                    sum += Data.QuestionCost;
            }
            return sum;

        }
    }
}
