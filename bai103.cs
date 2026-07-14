using System;
namespace ChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine(). Split();
            int d = int.Parse(input[0]);
            int r = int.Parse(input[1]);
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= d; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}