using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj długości boków trójkąta oddzielone przecinkiem");
        string[] sides = Console.ReadLine().Split(",");
        int a = Convert.ToInt32(sides[0]);
        int b = Convert.ToInt32(sides[1]);
        int c = Convert.ToInt32(sides[2]);

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("Mozna zbudować trójkąt");
        }
        else
        {
            Console.WriteLine("Nie można zbudować trójkąta");
        }
    }
}