using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj swój wzrost w cm: ");
        int wzrost = Convert.ToInt32 (Console.ReadLine());

        if (wzrost < 150)
        {
            Console.WriteLine("Jesteś krasnoludem");
        }
        else if (wzrost >= 150 && wzrost < 160)
        {
            Console.WriteLine("Jesteś hobbit");
        }
        else if (wzrost >= 160 && wzrost < 175)
        {
            Console.WriteLine("Jesteś średniego wzrostu");
        }
        else if (wzrost >= 175 && wzrost < 190)
        {
            Console.WriteLine("Jesteś wysoki");
        }
        else
        {
            Console.WriteLine("Jesteś olbrzymem");
        }
    }
}
