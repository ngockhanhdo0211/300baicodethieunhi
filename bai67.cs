//Tính tổng những số tự nhiên chia hết cho 3 và 5 từ 1 đến n
using System;
namespace TinhTong
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++ )
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.Write(sum);
        }
    }
}