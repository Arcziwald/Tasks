using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwszą liczbę: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę: ");
        int number2 = int.Parse(Console.ReadLine());

        int nww = FindNWW(number1, number2);

        Console.WriteLine($"Najmniejsza wspólna wielokrotność dla {number1} i {number2} to {nww}");
    }

    static int FindNWW(int a, int b)
    {
        return Math.Abs(a * b) / FindNWD(a, b);
    }

    static int FindNWD(int a, int b)
    {
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }
        return a;
    }
}
