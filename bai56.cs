// Tìm số lớn nhất trong 4 số
using System;
namespace SoLonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int d = int.Parse(input[3]);
            if (a > b && a > c && a > d)
            {
                Console.Write(a);
            } else if (b > a && b > c && b > d)
            {
                Console.Write(b);
            } else if (c > a && c > b && c > d)
            {
                Console.Write(c);
            } else if (d > a && d > b && d > c)
            {
                Console.Write(d);
            } else
            {
                Console.Write("=");
            }
        }
    }
}