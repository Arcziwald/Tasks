using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbe:");
        int liczba = Convert.ToInt32 (Console.ReadLine());

        if (liczba % 2 == 0) 
        {
            Console.WriteLine($"{liczba} jest liczbą parzystą");
        }
        else
        {
            Console.WriteLine($"{liczba} jest liczbą nieparzystą");
        }
    }
}
