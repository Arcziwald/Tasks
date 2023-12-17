using System;

class Program
{
    static void Main()
    {
        double width, length, diagonal;

        Console.Write("Podaj szerokość prostokąta: ");
        width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj długość prostokąta: ");
        length = Convert.ToDouble(Console.ReadLine());

        diagonal = Math.Sqrt(Math.Pow(szerokosc, 2) + Math.Pow(dlugosc, 2));

        Console.WriteLine($"Długość przekątnej prostokąta: {przekatna}");
    }
}