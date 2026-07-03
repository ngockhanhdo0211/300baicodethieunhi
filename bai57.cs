// Kiểm tra ba số có là e cạnh của một tam giác và chu vi, diện tích.
using System;
namespace KiemTra
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Day la 3 canh cua mot tam giac");
            int chuvi = a + b + c;
            double p = chuvi / 2.0;
            double s = Math.Sqrt(p * (p -a) * (p - b) * (p - c));
            Console.Write(chuvi + " " + $"{s:F1}");
            } else
            {
                Console.WriteLine("Day khong phai la 3 canh cua mot tam giac");
            }
        }
    }
}