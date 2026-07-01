// Kiểm tra số nguyên có lớn hơn 100?
using System;
namespace KiemTraSoNguye
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if ( n > 100)
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }
        }
    }
}