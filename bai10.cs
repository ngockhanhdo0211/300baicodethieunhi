using System;

namespace BieuThuc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            double P = (21.0 * Math.Pow(a, 2) + 5.0 * Math.Pow(b, 2))
                     / (2009.0 * Math.Pow(c, 2) + 15.0);

            double Q = Math.Sqrt(Math.Pow(a, 2) - 2.0 * b)
                     / (3.0 * Math.Pow(c, 2) + 4.0);

            Console.Write($"{P:F4} {Q:F4}");
        }
    }
}