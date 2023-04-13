namespace TelegramBot.Classes.JSON
{
    public class Part
    {
        public string Name { get; set; }
        public string Theory { get; set; }

        public VictorineData Victorine { get; set; }

        public Part(string name, string theory, VictorineData data)
        {
            Name = name;
            Theory = theory;
            Victorine = data;
        }
    }
}
