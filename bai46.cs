// Tìm số ngày của một tháng
//Nhập vào một tháng và năm, cho biết tháng đó có bao nhiêu ngày
// Năm nhuận thì tháng 2 có 29 ngày, kh thì tháng 2 có 28 ngày
// Năm nhuận là năm chia hết cho 400 hoặc chia hết cho 4 nhưng kh chia hết cho 100
using System;
namespace SoNgay
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int t = int.Parse(input[0]);
            int n = int.Parse(input[1]);
           bool namNhuan = (n % 400 == 0) || (n % 4  == 0 && n % 100 != 0);
           if (t == 1 || t == 3 || t == 5 || t == 7 || t == 8 || t == 10 || t == 12)
            {
                Console.Write(31);
            }
            if (t == 4 || t == 6 || t == 9 || t == 11)
            {
                Console.Write(30);
            }
            if (t == 2 && namNhuan)
            {
                Console.Write(29);
            }
            if (t == 2 && !namNhuan)
            {
                Console.Write(28);
            }
        }
    }
}