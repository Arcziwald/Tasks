using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wiek: ");
        int wiek = Convert.ToInt32(Console.ReadLine());

        if (wiek >= 21)
        {
            Console.WriteLine("Możesz zostać posłem");
        }

        if (wiek >= 30)
        {
            Console.WriteLine("Możesz zostać senatorem");
        }

        if (wiek >= 35)
        {
            Console.WriteLine("Mozesz zostać premierem");
        }

        if (wiek >= 35)
        {
            Console.WriteLine("Mozesz zostać prezydentem");
        }
    }
}