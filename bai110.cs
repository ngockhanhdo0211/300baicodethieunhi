// Kiểm tra một số nguyên có là số đối xứng (Palindrome)
using System;
namespace KiemTra
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long goc = n;
            long dao = 0;
            while(n > 0) {
                long chuSo = n % 10;
                dao = dao * 10 + chuSo;
                n = n / 10;
            }
            if (goc == dao)
            Console.Write("Yes");
            else
            Console.Write("No");
        }
    }
}