using System;

namespace TimSo
{
    class Program
    {
        // Hàm kiểm tra số nguyên tố
        static bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        // Hàm kiểm tra số Chen
        static bool IsChen(int n)
        {
            return IsPrime(n) && IsPrime(n + 2);
        }

        static void Main()
        {
            int k = int.Parse(Console.ReadLine());

            int dem = 0;
            int tong = 0;
            int n = 2;

            while (dem < k)
            {
                if (IsChen(n))
                {
                    tong += n;
                    dem++;
                }

                n++;
            }

            Console.WriteLine(tong);
        }
    }
}