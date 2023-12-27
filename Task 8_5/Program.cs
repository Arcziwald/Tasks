using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine($"{i}^3 = {Math.Pow(i,3)}");
        }
    }
}
