// Đếm số nguyên chia hết cho 5 và in những số chia hết cho 5 từ m đến n
using System;
namespace SoNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int count = 0;
            int sum = 0;
            for(int i = m; i <= n; i++)
            {
                if(i % 5 == 0)
                {
                    count++;
                    
                }
            }
            Console.Write(count + " - ");
            for (int i = m; i <= n; i++)
            {
                if (i % 5  == 0)
                {
                    Console.Write(i + " ");
                }
            }
            
        }
    }
}