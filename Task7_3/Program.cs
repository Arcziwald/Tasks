using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
                {
            Console.WriteLine($"{number} jest liczbą dodatnią");
        }
      else if (number < 0)
        {
            Console.WriteLine($"{number} jest liczbą ujemną");
        }
      else 
        {
            Console.WriteLine("Liczba to 0");
        }

    }
}
