using System;
namespace TinhTongCacChuSO
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int Tong = 0;
            Tong += a % 10;
            a /= 10;

            Tong += a % 10;
            a /= 10;

            Tong += a % 10;
            a /= 10;

            Tong += a % 10;
            Console.Write(Tong);
        }
    }
}