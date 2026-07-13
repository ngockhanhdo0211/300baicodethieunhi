// Đảo ngược chữ số của một số nguyên n
using System;
namespace DaoNguoc
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong dao = 0;
            while (n > 0)
            {
                ulong digit = n % 10;
                dao = dao * 10 + digit;
                n = n / 10;
            }
            Console.WriteLine(dao);
        }
    }
}