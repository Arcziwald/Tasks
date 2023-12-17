using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbe:");
        int number = Convert.ToInt32 (Console.ReadLine());

        if (number % 2 == 0) 
        {
            Console.WriteLine($"{number} jest liczbą parzystą");
        }
        else
        {
            Console.WriteLine($"{number} jest liczbą nieparzystą");
        }
    }
}
