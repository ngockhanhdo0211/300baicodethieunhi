// Tính trung bình cộng các số nguyên tố từ m đến n
using System;
namespace NguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            long sum = 0;
            int count = 0;
            for (int i = m; i <= n; i++)
            {
                if (i < 2) continue;
                bool isPrime = true;
                for (int j = 2; j * j <= i; j++ )
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    sum += i;
                    count++;
                }
            }
            double average = count > 0 ? (double) sum / count : 0;
            Console.WriteLine($"{average:F1}");
        }
    }
}