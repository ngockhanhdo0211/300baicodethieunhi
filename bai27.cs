// Tính bán kính hình tròn ngoại tiếp tam giác
// Nhập vào ba cạnh a,b,c của một tam giác
// Tính bán kính R của đường tròn ngoại tiếp tam giác đó theo công thức.
// R = a *b * c / 4 * S;
using System;
namespace BanKinh
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            double p = (a + b + c) / 2.0;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double R = (a * b * c) / (4.0 * S);
            Console.Write($"{R:F3}");
        }
    }
}