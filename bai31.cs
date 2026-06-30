// Tính diện tích hình vuông
// Nhập vào chu vi của một hình vuông, tính diện tích hình vuông đó
using System;
namespace HinhVuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double canh = a / 4;
            double dt = Math.Pow(canh, 2);
            Console.Write(dt);
        }
    }
}