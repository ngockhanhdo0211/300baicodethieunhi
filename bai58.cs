// Kiểm tra 2 số a, b có là 2 kích thước của hình chữ nhật, chu vi, diện tích.
using System;
namespace KimTra
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            if ( a > 0 && b > 0)
            {
                Console.WriteLine("Day la 2 kich thuoc cua mot hinh chu nhat");
                double chuvi = (a + b) * 2;
                double s = a * b;
                Console.Write(chuvi + " " + s);
            } else if ( a < 0 && b > 0)
            {
                Console.WriteLine("Day khong phai la 2 kich thuoc cua mot hinh chu nhat");
                Console.Write("a la so am");
            } else if (a > 0 && b < 0)
            {
                Console.WriteLine("Day khong phai la 2 kich thuoc cua mot hinh chu nhat");
                Console.Write("b la so am");
            } else
            {
                Console.WriteLine("Day khong phai la 2 kich thuoc cua mot hinh chu nhat");
                Console.Write("a va b la so am");
            }
        }
    }
}