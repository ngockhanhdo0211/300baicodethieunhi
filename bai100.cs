// Tính trung bình cộng k số tự nhiên đầu tiên không chia hết cho 3
using System;
namespace TrungBinh
{
    class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int dem = 0;
            int tong  = 0;
            for ( int i = 1; ; i++)
            {
                if (i % 3 != 0)
                {
                    tong += i;
                    dem++;
                    if (dem == k)
                    break;
                }
            }
            double tbc = (double)tong / k;
            Console.WriteLine(tbc.ToString("0.0"));
        }
    }
}