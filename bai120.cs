using System;
namespace SoNguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            long sum = 0;

            for (int i = m; i <= n; i++)
            {
                if (i < 2) continue; // số nguyên tố phải > 1

                bool isPrime = true;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime) sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}