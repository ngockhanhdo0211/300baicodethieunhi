//In ra các số nguyên dương chẵn cho đến khi tổng của chúng >= k
using System;
using System.Text;
class Program
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine().Trim());
        int sum = 0;
        int number = 2;
        StringBuilder sb = new StringBuilder();
        while (sum < k)
        {
            if (sb.Length > 0) sb.Append(' ');
            sb.Append(number);
            sum += number;
            number += 2;
        }
        Console.WriteLine(sb.ToString());
    }
}