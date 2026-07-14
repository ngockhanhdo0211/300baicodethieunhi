// Tính sô tháng gửi tiền tiết kiểm để được số tiền n
using System;
namespace TinhTien
{
    class Program
    {
        static void Main(string[] args)
        {
            long a, b;
            string[] input = Console.ReadLine().Split();
            a = long.Parse(input[0]);
            b = long.Parse(input[1]);
            double tien = a;
            int thang = 0;
            while (tien < b)
            {
                tien = tien * 1.02;
                thang++;
            }
            Console.WriteLine(thang);
        }
    }
}