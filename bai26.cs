// Tính tích tam giác 2
// Nhập vào ba số a,b,c của một tam giác
//Tính chu vi và diện tích của tam giác đó
//cv = a + b+ c
// s = Math.sqrt(p * (p - a) )
using System;
namespace DienTichTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            double cv = a + b + c;
            double p = cv / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine(cv);
            Console.Write($"{s:F3}");

        }
    }
}