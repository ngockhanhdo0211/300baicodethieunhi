// Tìm ước chung lớn nhất của hai số nguyê a và b
using System;
namespace UocChung
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = Math.Abs(int.Parse(input[0]));
            int b = Math.Abs(int.Parse(input[1]));
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            Console.WriteLine(a);

        }
    }
}