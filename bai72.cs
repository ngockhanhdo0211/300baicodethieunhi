// In những số tự nhiên từ m đến n
using System;
namespace TuNhien
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for(int i = m; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            
        }
    }
}