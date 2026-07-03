using System;

namespace TinhTong
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            int tong = 0;
            bool coSoChan = false;

            for (int i = 0; i < a.Length; i++)
            {
                int digit = a[i] - '0';
                if (digit % 2 == 0)
                {
                    tong += digit;
                    coSoChan = true;
                }
            }

            if (coSoChan)
                Console.Write(tong);
            else
                Console.Write("-");
        }
    }
}