using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj ocenę (1-6): ");
        int rating = Convert.ToInt32(Console.ReadLine());

        switch (rating)
        {
            case 6: Console.WriteLine("Celujący");
                break;
            case 5: Console.WriteLine("Bardzo dobry");
                break;
            case 4: Console.WriteLine("Dobry");
                break;
            case 3: Console.WriteLine("Dostateczny");
                break;
            case 2: Console.WriteLine("Dopuszczający");
                break;
            case 1: Console.WriteLine("Niedostateczny");
                break;
            default: Console.WriteLine("Niepoprawna ocena");
                break;
        }
    }
}
