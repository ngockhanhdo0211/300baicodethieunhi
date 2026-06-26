//Nhập số tiền N đồng, đổi ra xem được bao nhiêu tờ 5.00 đồng
// bao nhiêu tờ 2.000 đồng
// bao nhiêu tờ 1.000 đồng
using System;
namespace DoiTien2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int to5 = N / 5000;
            N %= 5000;
            int to2 = N / 2000;
            N %= 2000;
            int to1 = N / 1000;
            N %= 1000;
            Console.Write(to5 + " " + to2 +  " " + to1);
        }
    }
}