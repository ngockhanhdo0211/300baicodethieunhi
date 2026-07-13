using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine().Trim();
        ulong n = ulong.Parse(input);

        int min = 10; // giá trị khởi tạo lớn hơn mọi chữ số có thể (0-9)
        while (n > 0)
        {
            int digit = (int)(n % 10);
            if (digit % 2 == 0)
            {
                if (digit < min)
                {
                    min = digit;
                }
            }
            n /= 10;
        }

        if (min == 10)
            Console.WriteLine("-");
        else
            Console.WriteLine(min);
    }
}