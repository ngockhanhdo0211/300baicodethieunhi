// Tìm chữ số lẻ lớn nhất của một số nguyên n
using System;

class Program
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());

        int max = -1;

        while (n > 0)
        {
            int digit = (int)(n % 10);

            if (digit % 2 == 1 && digit > max)
            {
                max = digit;
            }

            n = n / 10;
        }

        Console.WriteLine(max);
    }
}