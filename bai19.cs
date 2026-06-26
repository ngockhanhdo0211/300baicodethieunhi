// Bài tập đổi giờ phút giây
using System;
namespace DoiGio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int gio = n / 3600;
            n %= 3600;
            int phut = n / 60;
            n %= 60;
            int giay = n;

            Console.Write(gio +":"+ phut + ":" + giay);
        }
    }
}