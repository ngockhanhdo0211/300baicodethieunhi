// In những số nguyên chẵn từ m đến n
using System;
namespace NguyenChan
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = m; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i + " ");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("-");
            } 
        }
    }
}