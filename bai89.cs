using System;

namespace TinhTong
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string n = input[0];
            int x = int.Parse(input[1]);

            int sum = 0;

            foreach (char c in n)
            {
                int digit = c - '0';

                if (digit > x)
                {
                    sum += digit;
                }
            }

            Console.WriteLine(sum);
        }
    }
}