// Tính diện tích hình tròn
// Nhập vào chu vi của một hình trong, diện tích hình trong đó
using System;
namespace HinhTron{
class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double dt = Math.Pow(a, 2) / (4.0 * 3.14);
        Console.Write($"{dt:F2}");
    }
    }
}