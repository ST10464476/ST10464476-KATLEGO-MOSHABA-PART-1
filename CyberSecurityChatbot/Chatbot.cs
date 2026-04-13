namespace System;
using System.Threading;

public class Chatbot
{
    public string UserName { get; set; }

    public Chatbot(string name)
    {
        UserName = name;
    }

    public void StartChat()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nYou: ");
            Console.ResetColor();

            string input = Console.ReadLine()?.ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                Respond("Please enter something.");
                continue;
            }

            if (input.Contains("exit"))
            {
                Respond("Goodbye! Stay safe online 🔐");
                break;
            }

            HandleInput(input);
        }
    }

    private void HandleInput(string input)
    {
        if (input.Contains("how are you"))
        {
            Respond($"I'm just code, but I'm here to help you, {UserName}!");
        }
        else if (input.Contains("purpose"))
        {
            Respond("I help users stay safe online by teaching cybersecurity awareness.");
        }
        else if (input.Contains("password"))
        {
            Respond("Use strong passwords with letters, numbers, and symbols. Avoid personal info.");
        }
        else if (input.Contains("phishing"))
        {
            Respond("Be careful of emails asking for personal info. Always verify the sender.");
        }
        else if (input.Contains("safe browsing"))
        {
            Respond("Only visit secure websites (https) and avoid suspicious links.");
        }
        else
        {
            Respond("I didn’t quite understand that. Could you rephrase?");
        }
    }

    private void Respond(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;

        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(20); // typing effect
        }

        Console.WriteLine();
        Console.ResetColor();
    }
}