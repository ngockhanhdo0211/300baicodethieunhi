//Đếm số lượng số nguyên chẵn từ m đến n
// Nhập vào hai số nguyên m và n ( m <= n)
using System;
namespace SoLuong
{
    class Program
    {
        static void Main(string[]args)
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int count = 0;
            for(int i = m; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}