// Kiểm tra số nguyên dương hay âm
using System;
namespace KiemTra
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if ( a > 0)
            {
                Console.Write("So duong");
            }
            if (a < 0 )
            {
                Console.Write("So am");
            }
            if (a == 0)
            {
                Console.Write("So khong");
            }
        }
    }
}