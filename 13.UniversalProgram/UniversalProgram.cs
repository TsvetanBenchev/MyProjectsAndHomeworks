using System;

class UniversalProgram
{
    static void Main(string[] args)
    {
        while (true)
        {
        Console.WriteLine("--------- Welcome to the universal program ---------");
        Console.WriteLine("Select 1 to reverse a digit.");
        Console.WriteLine("Select 2 to find average value in sequence of integers.");
        Console.WriteLine("Select 3 to solve linear equation.");
        Console.WriteLine("Select 4 to exit the program");
        Console.Write("Your choice: ");
        int input = int.Parse(Console.ReadLine());
        
        if (input == 1)
        {
            //Reverse
            Console.Write("Enter number to reverse:");
            string number = Console.ReadLine();
            int intNum = int.Parse(number);
            if (intNum < 0)
            {
                Console.WriteLine("Non-negative numbers allowed only.Choose once again a positive one.");
                continue;
            }
            else
            {
                Reverse(number);
            }
        }
        else if (input == 2)
        {
            //Find average
            Console.Write("Enter how many numbers: ");
            int nums = int.Parse(Console.ReadLine());
            int[] array = new int[nums];
            FillArray(array);
                if (array == null || array.Length == 0)
                {
                    Console.WriteLine("The array should not be empty.");
                    continue;
                }
            Console.WriteLine("Average: " + FindAverage(array));
        }
        else if (input == 3)
        {
            //Solve equation
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("A should not be zero.");
                continue;
            }
            else
            {
                Console.Write("Enter b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("X is : " + SolveEquation(a, b));   
            }
        }
        else if (input == 4)
        {
            return;
        }
        else if (input != 1 || input != 2 || input != 3 || input != 4)
        {
            Console.WriteLine("Bad or incorrect input.");
        }
        }
    }

    static double FindAverage(int[] array)
    {
        int sum = 0;
        double average = 0;
        int residue = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        residue = sum % array.Length;
        average = (sum / array.Length) + (0.1 * residue);
        return average;
    }

    static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("num[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    static void Reverse(string num)
    {
        bool isNegative = false;
        char[] reverse = num.ToCharArray();
        Console.Write("Reversed :");
        if (reverse[0] == '-')
        {
            Console.Write('-');
            isNegative = true;
        }
        Array.Reverse(reverse);

        for (int i = 0; i < reverse.Length; i++)
        {
            if (isNegative == true && i == reverse.Length - 1)
            {
                break;
            }
            Console.Write(reverse[i]);
        }
        Console.WriteLine();
    }

    static double SolveEquation(int a, int b)
    {
        double result = -b / a;
        double residue = -b % a;
        result = result +  (0.1 * residue);
        return result;
    }
}