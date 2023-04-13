namespace TelegramBot.Classes.JSON
{
    public class Employee
    {
        public string FullName { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
            
        public Employee(string fullName, string description, string email)
        {
            FullName = fullName;
            Description = description;
            Email = email;
        }
    }
}
