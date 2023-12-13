using System;

class Program
{
    static void Main()
    {

        Console.Write("Podaj swoje imię: ");
        string name = Console.ReadLine();

        Console.Write("Podaj swoje nazwisko: ");
        string surname = Console.ReadLine();

        Console.Write("Podaj numer telefonu: ");
        string numberPhone = Console.ReadLine();

        Console.Write("Podaj adres email: ");
        string email = Console.ReadLine();

        Console.Write("Podaj wzrost w cm (np. 180): ");
        int growth = int.Parse(Console.ReadLine());

        Console.Write("Podaj wagę (np. 70,5): ");
        double weight = double.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Podaj wiek: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("\nZebrane dane:");
        Console.WriteLine($"Imię: {name}");
        Console.WriteLine($"Nazwisko: {surname}");
        Console.WriteLine($"Numer telefonu: {numberPhone}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Wzrost: {growth} cm");
        Console.WriteLine($"Waga: {weight} kg");
        Console.WriteLine($"Wiek: {age} years");
    }
}
