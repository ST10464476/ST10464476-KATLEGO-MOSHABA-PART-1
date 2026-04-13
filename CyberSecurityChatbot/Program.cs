namespace CyberSecurityChatbot;

class Program
{
    static void Main(string[] args)
    {
        AudioPlayer.PlayGreeting();
        UIHelper.DisplayHeader();

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("Name cannot be empty. Try again: ");
            name = Console.ReadLine();
        }

        Console.WriteLine($"\nWelcome, {name}! 👋");
        UIHelper.Divider();

        Chatbot bot = new Chatbot(name);
        bot.StartChat();
    }
}