using System;

class Program
{
    static void Main()
    {
        int number = 0;

        do
        {
            if (number % 2 == 0) 
            { 
                Console.WriteLine(number);
            }
            number++;
        } while (number <= 1000);
    }
}