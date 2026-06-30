// Tính trung bình cộng
// Nhập vào ba số nguyên a,b,c
// Tính trung bình cộng của ba số đó theo công thức
// TBC = (a + b + c) / 3, kết quả có 1 chữ số thập phân
using System;
namespace TrungBinhCong
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double TBC = (a + b + c) / 3.0;
            Console.Write($"{TBC:F1}");
        }
    }
}