// Tính x^n
using System;
namespace SoNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int ketQua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketQua *= x;
            }
            Console.WriteLine(ketQua);
        }
    }
}