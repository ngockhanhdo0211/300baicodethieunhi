// Đếm số lượng số tự nhiên chia hết cho e từ 1 đến n.
using System;
namespace SoLuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 1; i <= n; i++ )
            {
                if (i % 3 == 0)
                {
                    count ++;
                    
                }
            }
            Console.Write(count);
        }
    }
}