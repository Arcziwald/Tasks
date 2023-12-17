using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj rok: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 !=0) ||  (year % 400 == 0))
        {
            Console.WriteLine($"{year} jest rokiem przestępnym");
        }
        else
        {
            Console.WriteLine($"{year} nie jest rokiem przestępnym");
        }
    }
}

