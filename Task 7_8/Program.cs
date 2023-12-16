using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wynik z matematyki");
        int wynikMatematyka = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj wynik z fizyki");
        int wynikFizyka = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj wynik z chemii");
        int wynikChemia = Convert.ToInt32(Console.ReadLine());

        bool kwalifikacja = (wynikMatematyka > 70 && wynikFizyka > 55 && wynikChemia > 45 && (wynikMatematyka + wynikFizyka + wynikChemia) > 180) || (wynikMatematyka + Math.Max(wynikFizyka, wynikChemia) > 150);

        if (kwalifikacja)
            {
            Console.WriteLine("Kandydat dopuszczony do rekrutacji");
        }
        else
        {
            Console.WriteLine("Kandydat nie spełnia warunków rekrutacji");
        }
    }
}