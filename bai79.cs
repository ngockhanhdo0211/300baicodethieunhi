// Tính trung bình cộng những số nguyên chia hết cho 3 và 3 từ m đến n
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
            int sum5 = 0;
            int sum23 = 0;
            int count = 0;
            for (int i = m; i <= n; i++)
            {
                // Tổng số chia hết cho 5
                if ( i % 5 == 0)
                {
                    sum5 += i;
                }
                // trung bình số chia hết cho 2 và 3
                if (i % 2  == 0 && i % 3 == 0)
                {
                    sum23 += i;
                    count++;
                }
            }
            int avg = 0;
            if (count != 0)
            {
                avg = sum23 / count;
            }
            Console.WriteLine(sum5 + " " + avg);
        }
    }
}