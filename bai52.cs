// Kiểm tra số nguyên chẵn lẻ, âm dương
using System;
namespace ChanLe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Chan");
            } else
            {
                Console.WriteLine("Le");
            }
            if (n > 0)
            {
                Console.Write("Duong");
            }
            if (n < 0)
            {
                Console.Write("Am");
            }
            if (n == 0)
            {
                Console.Write("Khong");
            }
        }
    }
}