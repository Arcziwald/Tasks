using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwszą liczbę");
        int liczba1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę");
        int liczba2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj trzecią liczbę");
        int liczba3 = Convert.ToInt32(Console.ReadLine());

        int największa;

        if (liczba1 > liczba2 && liczba1 > liczba3)
        {
            największa = liczba1;
        }
        else if (liczba2 > liczba3)
        {
            największa = liczba2;
        }
        else
        {
            największa = liczba3;
        }
        Console.WriteLine($"{największa} jest największa z podanych");
    }
}
