using System;

class Pracownik
{
    static void Main()
    {
        string imie;
        string nazwisko;
        int wiek;
        char plec;
        string pesel;
        long numerPracownika;

        
        imie = "Artur";
        nazwisko = "Mochnia";
        wiek = 50;
        plec = 'm';
        pesel = "73050512345";
        numerPracownika = 2509324094;

        // Wyświetlanie danych
        Console.WriteLine("Dane pracownika:");
        Console.WriteLine($"Imię: {imie}");
        Console.WriteLine($"Nazwisko: {nazwisko}");
        Console.WriteLine($"Wiek: {wiek}");
        Console.WriteLine($"Płeć: {plec}");
        Console.WriteLine($"PESEL: {pesel}");
        Console.WriteLine($"Numer pracownika: {numerPracownika}");
    }
}

