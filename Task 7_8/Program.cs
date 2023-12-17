using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wynik z matematyki");
        int resultMath = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj wynik z fizyki");
        int resultPhysics = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj wynik z chemii");
        int resultChemistry = Convert.ToInt32(Console.ReadLine());

        bool qualification = (resultMath > 70 && resultPhysics > 55 && resultChemistry > 45 && (resultMath + resultPhysics + resultChemistry) > 180) || (resultMath + Math.Max(resultPhysics, resultChemistry) > 150);

        if (qualification)
            {
            Console.WriteLine("Kandydat dopuszczony do rekrutacji");
        }
        else
        {
            Console.WriteLine("Kandydat nie spełnia warunków rekrutacji");
        }
    }
}