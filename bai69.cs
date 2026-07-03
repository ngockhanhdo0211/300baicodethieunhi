// Tính trung bình cộng những số tự nhiên chẵn từ 1 đến n
using System;
namespace TinhTrungBinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long sum = 0;
            long count = 0;
            for(int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    count++;
                }

            }
            if (count == 0)
            {
                Console.Write(0);
            } else
            {
                Console.Write(sum / count);
            }
            
        }
    }
}