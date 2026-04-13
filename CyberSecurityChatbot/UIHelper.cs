using System;
using System.IO;

public class UIHelper
{
    public static void DisplayHeader()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        string ascii = File.ReadAllText("assets/ascii.txt");
        Console.WriteLine(ascii);

        Console.ResetColor();
    }

    public static void Divider()
    {
        Console.WriteLine("=======================================");
    }
}