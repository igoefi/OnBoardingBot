using TelegramBot.Classes.Users;

namespace TelegramBot.Classes.JSON
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Code { get; set; }
        public string Speciality { get; set; }
        public int SocialCredits { get; set; }
        public int SelectedChapter { get; set; }
        public bool IsEndedTest { get; set; } = true;
        public long ChatID { get;  set; }
        public Victrorine? SelectedVictorine { get; set; }

        public User(string firstName, string lastName, string code, string speciality)
        {
            FirstName = firstName;
            LastName = lastName;
            Code = code;
            Speciality = speciality;
            SocialCredits = 0;
            SelectedChapter = -1;
            ChatID = default;
            SelectedVictorine = null;
        }

        public string GetActualQuestion()
        {
            if (SelectedVictorine == null) return null;

            return SelectedVictorine.Value.GetActualQuestion();
        }

        public void SetChatID(long chatID) =>
            ChatID = chatID;

        public string SetAnswer(string answer)
        {
            if (SelectedVictorine == null)
                return null;
            SelectedVictorine.Value.AddAnswer(answer);

            int result = SelectedVictorine.Value.GetResultInCredits();
            if (result == -1) return null;
            int allSum = SelectedVictorine.Value.Data.QuestionCost * SelectedVictorine.Value.Data.QuestionsAnswers.Count;
            SelectedVictorine = null;
            PlusSocialCredits(result);
            IsEndedTest = true;
            return $"Результат: {result} из {allSum} социальных кредитов";
        }

        public void SetVictorine(Part part)
        {
            if (SelectedVictorine != null) return;

            SelectedVictorine = new Victrorine(part.Victorine);
            IsEndedTest = false;
        }

        private void PlusSocialCredits(int plus) =>
            SocialCredits += plus;
    }
}
