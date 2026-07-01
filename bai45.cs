// Kiểm tra chiều cao
// Nhập vào chiều cao của một người
// Nếu chiều cao > 180 => Huu cao co
// Nếu chiều cao < 100 => Nam lun cute
// else binhthuong
using System;
namespace ChieuCao
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 180)
            {
                Console.Write("Huu cao co");
            }
            if (n < 100)
            {
                Console.Write("Nam lun cute");
            }
            if (n > 100 && n < 180 )
            {
                Console.Write("Binh thuong");
            }
        }
    }
}