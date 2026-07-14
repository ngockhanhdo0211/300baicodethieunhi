using System;

class Program
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());

        for (int i = 1; i <= h; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}