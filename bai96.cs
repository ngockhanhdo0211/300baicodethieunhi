using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine().Trim();
        ulong n = ulong.Parse(input);

        while (n >= 10)
        {
            ulong sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            n = sum;
        }

        Console.WriteLine(n);
    }
}