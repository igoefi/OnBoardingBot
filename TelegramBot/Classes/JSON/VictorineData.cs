using System.Collections.Generic;

namespace TelegramBot.Classes.JSON
{
    public class VictorineData
    {
        public Dictionary<string, string> QuestionsAnswers { get; set; } = new Dictionary<string, string>();
        public int QuestionCost { get; set; }

        public VictorineData(Dictionary<string, string> questionsAnswers, int questionCost)
        {
            QuestionsAnswers = questionsAnswers;
            QuestionCost = questionCost;
        }
    }
}
