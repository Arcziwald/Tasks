using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwszą liczbę: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj numer operacji do wykonania: ");
        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnożenie");
        Console.WriteLine("4. Dzielenie");

        int operacja = Convert.ToInt32(Console.ReadLine());
        double result;

        switch(operacja)
        {
            case 1:
                result = number1 + number2;
                break;
            case 2:
                result = number1 - number2;
                break;
            case 3:
                result = number1 * number2;
                break;
            case 4:
                if (number2 !=0)
                {
                    result = number1 / number2;
                }
                else
                {
                    Console.WriteLine("Nie można dzielić przez 0");
                    return;
                }
                break;
                default: Console.WriteLine("Niepoprawny numer operacji");
                return;
        }
        Console.WriteLine($"Twój wynik to:{result}");
    }
}
