using System;

class Program
{
    static void Main()
    {
        double szerokosc, dlugosc, przekatna;

        Console.Write("Podaj szerokość prostokąta: ");
        szerokosc = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj długość prostokąta: ");
        dlugosc = Convert.ToDouble(Console.ReadLine());

        przekatna = Math.Sqrt(Math.Pow(szerokosc, 2) + Math.Pow(dlugosc, 2));

        Console.WriteLine($"Długość przekątnej prostokąta: {przekatna}");
    }
}