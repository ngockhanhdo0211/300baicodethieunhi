//Tính chu vi và diện tích hình chữ nhật
// Nhập vào chiều dài a và chiều rộng b của một hình chữ nhật
// Tính chu vi và diện tích hình chữ nhật theo công thức
// cv = (a + b * 2)
// dt = a * b;
using System;
namespace DienTich
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            double cv = (a + b) * 2;
            double dt = a * b;
            Console.Write(cv + " " + dt);
        }
    }
}