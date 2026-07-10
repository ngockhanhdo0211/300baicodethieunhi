using System;

namespace TinhTong
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);

            int count7 = 0;
            int sum23 = 0;
            int count23 = 0;

            for (int i = m; i <= n; i++)
            {
                if (i % 7 == 0)
                {
                    count7++;
                }

                if (i % 2 == 0 || i % 3 == 0)
                {
                    sum23 += i;
                    count23++;
                }
            }

            double avg = 0;

            if (count23 != 0)
            {
                avg = (double)sum23 / count23;
            }

            Console.WriteLine(count7 + " " + avg.ToString("F1"));
        }
    }
}