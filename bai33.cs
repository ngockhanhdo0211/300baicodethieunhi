using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        if (a > b)
        {
            Console.Write("An");
        }

        if (a < b)
        {
            Console.Write("Bình");
        }

        if (a == b)
        {
            Console.Write("Bang nhau");
        }
    }
}