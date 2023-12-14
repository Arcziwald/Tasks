using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę: ");
        int liczba = Convert.ToInt32(Console.ReadLine());

        if (liczba > 0)
                {
            Console.WriteLine($"{liczba} jest liczbą dodatnią");
        }
      else if (liczba < 0)
        {
            Console.WriteLine($"{liczba} jest liczbą ujemną");
        }
      else 
        {
            Console.WriteLine("Liczba to 0");
        }

    }
}
