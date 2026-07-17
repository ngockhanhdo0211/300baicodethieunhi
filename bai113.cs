using System;

class Program
{
    // Hàm tính tổng các chữ số của một số
    static long SumDigits(long n)
    {
        long sum = 0;

        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }


    // Hàm kiểm tra số nguyên tố
    static bool IsPrime(long n)
    {
        if (n < 2)
            return false;

        for (long i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }


    // Hàm tính tổng chữ số của các thừa số nguyên tố
    static long SumPrimeFactors(long n)
    {
        long sum = 0;

        for (long i = 2; i * i <= n; i++)
        {
            while (n % i == 0)
            {
                sum += SumDigits(i);
                n /= i;
            }
        }

        // Nếu còn lại n > 1 thì n là thừa số nguyên tố cuối
        if (n > 1)
        {
            sum += SumDigits(n);
        }

        return sum;
    }


    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        // Số nguyên tố không phải số Smith
        if (IsPrime(n))
        {
            Console.Write("No");
            return;
        }

        long sumN = SumDigits(n);
        long sumFactor = SumPrimeFactors(n);

        if (sumN == sumFactor)
            Console.Write("Yes");
        else
            Console.Write("No");
    }
}