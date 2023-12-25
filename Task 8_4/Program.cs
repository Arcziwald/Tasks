using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę całkowitą: ");
        int maxNumber;
        
        if(!int.TryParse(Console.ReadLine(), out maxNumber))
        {
            Console.WriteLine("To nie jest prawidłowa liczba całkowita");
            return;
        }

        int currentNumber = 1;

        for(int i = 1; currentNumber < maxNumber; i++)
        {
            for (int j = 0; j < i && currentNumber <= maxNumber; j++)
            {
                Console.WriteLine(currentNumber + " ");
                currentNumber++;
            }
            Console.WriteLine();
        }
        
    }
}