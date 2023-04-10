using System.Collections.Generic;
using TelegramBot.Classes.JSON;

namespace TelegramBot.Classes.Users
{
    public struct Victrorine
    {
        public VictorineData Data { get; private set; }
        private readonly Queue<string> Answers;
        public Victrorine(VictorineData data)
        {
            Data = data;
            Answers = new Queue<string>();
        }

        public void AddAnswer(string answer) =>
            Answers.Enqueue(answer);

        public int GetResultInCredits()
        {
            var quests = Data.QuestionsAnswers;

            if (Answers.Count != quests.Count)
                return -1;

            int sum = 0;
            foreach (var question in quests.Keys)
            {
                if (quests[question].ToLower() == Answers.Dequeue().ToLower())
                    sum += Data.QuestionCost;
            }
            return sum;
        }
    }
}
