namespace TelegramBot.Classes.JSON
{
    public class Part
    {
        public string Name { get; private set; }
        public string Theory { get; private set; }

        public VictorineData Victorine { get; private set; }

        public Part(string name, string theory, VictorineData data)
        {
            Name = name;
            Theory = theory;
            Victorine = data;
        }
    }
}
