using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę dziesiętną: ");
        int decimalNumber;
        if(!int.TryParse(Console.ReadLine(), out decimalNumber))
        {
            Console.WriteLine("TO nie jest prawidłowa liczba całkowita");
            return;
        }
        string binaryNumber = Convert.ToString(decimalNumber, 2);

        Console.WriteLine($"Liczba binarna: {binaryNumber}");
    }
}
