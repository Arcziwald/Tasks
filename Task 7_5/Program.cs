using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wiek: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 21)
        {
            Console.WriteLine("Możesz zostać posłem");
        }

        if (age >= 30)
        {
            Console.WriteLine("Możesz zostać senatorem");
        }

        if (age >= 35)
        {
            Console.WriteLine("Mozesz zostać premierem");
        }

        if (age >= 35)
        {
            Console.WriteLine("Mozesz zostać prezydentem");
        }
    }
}