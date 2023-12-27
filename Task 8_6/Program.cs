using System;

class Program
{
    static void Main()
    {
        double sum = 0;

        for(int i = 1; i <= 20; i++)
        {
            sum += 1.0/ i;
        }
        Console.WriteLine($"Suma wynosi: {sum}");
    }
}
