// Kiểm tra một số nguyên có là số Pronic
// Một số được gọi là số pronic nếu: n = m * (m + 1).
using System;
namespace SoPronic
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool check  = false;
            for (long m = 0;m * (m + 1 ) <= n; m++ )
            {
                if ( m * (m + 1) == n)
                {
                    check = true;
                    break;
                }
            }
            if (check)
            Console.WriteLine("Yes");
            else
            Console.WriteLine("No");

        }
    }
}