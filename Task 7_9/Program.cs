﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj temperaturę");
        int temperature = Convert.ToInt32(Console.ReadLine());

        if(temperature < 0) 
        {
            Console.WriteLine("cholernie piździ");
        }
        else if(temperature >=0 && temperature < 10)
        {
            Console.WriteLine("zimno");
        }
        else if (temperature >= 10 && temperature < 20)
        {
            Console.WriteLine("chłodno");
        }
        else if (temperature >= 20 && temperature < 30)
        {
            Console.WriteLine("w sam raz");
        }
        else if (temperature >= 30 && temperature < 40) 
        {
            Console.WriteLine("zaczyna być słabo , bo gorąco");
        }
        else if (temperature >= 40)
        {
            Console.WriteLine("a weź wyprowadzam się na Alaskę");
        }
    }
}