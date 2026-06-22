// 007. Nghịch đảo
// Cho một số thực a, hãy tính B = 1 phần a và in kq ra mh với năm chữ thập phân
using System;
namespace NghichDao
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double B = 1.0 / a;
            Console.WriteLine($"{B:F5}");
        }
    }
}