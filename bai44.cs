// Kiểm tra cân nặng
// Nhập vào cân ạng của 1 ng
// Nếu cân nặng > 80 => Béo phì
// Nếu cân nặng < 45 => Suy dinh dưỡng
// else Bình thường
using System;
namespace KiemTra
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 80)
            {
                Console.Write("Beo phi");
            }
            if (n < 45)
            {
                Console.Write("Suy dinh duong");
            } 
            if (n > 45 && n < 80)
            {
                Console.Write("Binh thuong");
            }
        }
    }
}