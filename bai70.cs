//Tính trung bình cộng những số tự nhiên chia hết cho 5 từ 1 đến n
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
                if(i % 5 == 0)
                {
                    sum += i;
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("0.0");
            } else
            {
                double ketQua = (double)sum / count;
                Console.WriteLine($"{ketQua :F1}");
            }
        }
    }
}