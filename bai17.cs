// Nhập vào một số tiền a đồng.
// Tính số tờ 5.000 đồng nhiều nhất khi đổi từ số tiền a, và số tiền còn lại sau khi đổi
using System;
namespace DoiTien
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double soTo = a / 5000;
            double soTien = a % 5000;
            Console.Write(soTo + " " + soTien);
        }
    }
}