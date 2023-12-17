using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj swój wzrost w cm: ");
        int growth = Convert.ToInt32 (Console.ReadLine());

        if (growth < 150)
        {
            Console.WriteLine("Jesteś krasnoludem");
        }
        else if (growth >= 150 && growth < 160)
        {
            Console.WriteLine("Jesteś hobbit");
        }
        else if (growth >= 160 && growth < 175)
        {
            Console.WriteLine("Jesteś średniego wzrostu");
        }
        else if (growth >= 175 && growth < 190)
        {
            Console.WriteLine("Jesteś wysoki");
        }
        else
        {
            Console.WriteLine("Jesteś olbrzymem");
        }
    }
}
