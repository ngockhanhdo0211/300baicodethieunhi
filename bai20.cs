// Bài tập tính số bàn học sinh
using System;
namespace SoBan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int soBan = (a + 1) / 2 + (b + 1) / 2 + (c + 1) / 2;
            Console.Write(soBan);
        }
    }
}