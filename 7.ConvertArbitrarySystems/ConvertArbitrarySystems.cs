using System;

class ConvertArbitrarySystems
{
    static void Main(string[] args)
    {
        // Works for 2, 8, 10 and 16 base.
        Console.Write("Enter the base of the system you would like to convert from: ");
        int s = int.Parse(Console.ReadLine());
        if ( s < 2)
        {
            Console.WriteLine("Incorrect input!");
        }
        Console.Write("Enter base to convert to: ");
        int d = int.Parse(Console.ReadLine());
        if (d > 16)
        {
            Console.WriteLine("Incorrect input!");
        }

        Console.WriteLine("Enter your number: ");
        string binary = Console.ReadLine();
        string result = Convert.ToString(Convert.ToInt32(binary, s), d);
        Console.Write("Result: " + result);
        Console.WriteLine();
    }
}
