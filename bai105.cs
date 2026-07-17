// In ra bảng cửu chương của số tự nhiên n theo định dạng phép nhân
using System;
namespace CuuChuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
               Console.WriteLine($"{i} x {n} = {i * n}");
            }
            
        }
    }
}