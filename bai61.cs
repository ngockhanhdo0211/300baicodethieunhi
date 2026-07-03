// Tìm chữ số lớn nhất và nhỏ nhất của một số có 8 chữ số
// Chữ số lớn nhất và nhỏ nhất cảu a trên moojt dòng cách nhau bởi dấu cách
using System;
namespace LonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            char max = '0';
            char min = '9';
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.Write(max + " " + min);
        }
    }
}