using System.Collections.Generic;

namespace TelegramBot.Classes.JSON
{
    public class VictorineData
    {
        public Dictionary<string, string> QuestionsAnswers { get; private set; }
        public int QuestionCost;

        public VictorineData(Dictionary<string, string> questionsAnswers, int questionCost)
        {
            QuestionsAnswers = questionsAnswers;
            QuestionCost = questionCost;
        }
    }
}
