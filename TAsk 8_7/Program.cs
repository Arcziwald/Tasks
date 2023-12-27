using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj długość krótszej przekątnej diamentu: ");

        int length;
        if (!int.TryParse(Console.ReadLine(), out length) || length < 3 || length % 2 == 0)
        {
            Console.WriteLine("Nieprawidlowa wartość. Podaj nieparzystą liczbę większą lub równą 3");
            return;
        }
        DrawDiamond(length);
    }
    static void DrawDiamond(int length)
    {
        for (int i = 0; i < length / 2 + 1; i++)
        {
            Console.WriteLine(new string(' ', length / 2 - i));
            Console.WriteLine(new string('*', 2 * i + 1));
        }

        for (int i = length / 2 - 1; i >= 0; i--)
        {
            Console.WriteLine(new string(' ', length / 2 - i));
            Console.WriteLine(new string('*', 2 * i + 1));
        }
    }
}