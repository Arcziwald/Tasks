using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj rok: ");
        int rok = Convert.ToInt32(Console.ReadLine());

        if ((rok % 4 == 0 && rok % 100 !=0) ||  (rok % 400 == 0))
        {
            Console.WriteLine($"{rok} jest rokiem przestępnym");
        }
        else
        {
            Console.WriteLine($"{rok} nie jest rokiem przestępnym");
        }
    }
}

