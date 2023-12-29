using System;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadż ciąg znaków: ");

        string enteredText = Console.ReadLine();
        string reverseText = ReverseText(enteredText);

        Console.WriteLine($"Odwrócony ciąg znaków: {reverseText}");
    }
        static string ReverseText(string text)
    {
        char[] chars = text.ToCharArray();
        Array.Reverse( chars );
        return new string( chars );
    }
}