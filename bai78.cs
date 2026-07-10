// Tính trung bình cộng những số nguyên chẵn từ m đến n
using System;
namespace TrungBinh
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int sum = 0;
            int count = 0;
            for(int i = m; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    count++;
                } 
                
            }
            if (count == 0)
            {
                Console.WriteLine(0);
            } else
            {
                Console.WriteLine(sum / count);
            }
        }
    }
}