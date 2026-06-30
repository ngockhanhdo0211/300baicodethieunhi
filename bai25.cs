// Nhập vào chiều dài cạnh đáy a và chiều cao h tương ứng
// Tính diện tích tam giác đó theo công thức s = a * h / 2
using System;
namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a  = int.Parse(input[0]);
            int h = int.Parse(input[1]);
            double s =( a * h)/ 2.0;
            Console.Write($"{s:F1}");
        }
    }
}