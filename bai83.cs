// Rút gọn phân số
using System;
namespace RutGon
{
    class Program
    {
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split;
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int gcd = UCLN(a, b);
            a /= gcd;
            b /= gcd;
            Console.WriteLine(a + "/" + b);
        }
    }
}