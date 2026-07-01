using System;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]);
            long c = long.Parse(input[2]);

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine("Yes");

            if (a == b && b == c)
            {
                Console.WriteLine("Deu");
            }
            else if (a * a + b * b == c * c ||
                     a * a + c * c == b * b ||
                     b * b + c * c == a * a)
            {
                Console.WriteLine("Vuong");
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("Can");
            }
            else
            {
                Console.WriteLine("Thuong");
            }
        }
    }
}