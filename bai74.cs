// Đếm số lượng số nguyên chia hết cho 3 từ m đến n
using System;
namespace DemSo
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = m; i <= n; i++)
            {
                if(i % 3 == 0)
                {
                    count++;
                }
            }
            Console.Write(count);
        }
    }
}