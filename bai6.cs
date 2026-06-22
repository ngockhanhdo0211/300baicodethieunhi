// Phép toán tính lũy thừa
// Cho một số nguyên a, hãy tính B1 = a^2 và B2 = a^5
using System;
namespace LuyThua
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double B1 = Math.Pow(a, 2);
            double B2 = Math.Pow(a, 5);
            Console.WriteLine(B1);
            Console.WriteLine(B2);
        }
    }
}