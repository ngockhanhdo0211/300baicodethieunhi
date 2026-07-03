// In những số tự nhiên chia hết cho 3 từ 1 đến n.
using System;
namespace TimSo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if( i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            
        }
    }
}