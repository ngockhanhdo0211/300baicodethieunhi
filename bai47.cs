// Bài tập tính số nút
// Nhập vào số xe có 5 chữ số ở biển xe máy
// Tinh x là tổng các chữ số trong xe
// Nút là x chia 10 lấy dư
using System;

namespace TinhNut
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            int nut = sum % 10;

            Console.WriteLine(nut);

            if (nut == 9)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}