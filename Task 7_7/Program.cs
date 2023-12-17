using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwszą liczbę");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj trzecią liczbę");
        int number3 = Convert.ToInt32(Console.ReadLine());

        int largest;

        if (number1 > number2 && number1 > number3)
        {
            largest = number1;
        }
        else if (number2 > number3)
        {
            largest = number2;
        }
        else
        {
            largest = number3;
        }
        Console.WriteLine($"{largest} jest największa z podanych");
    }
}
