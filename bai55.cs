// Tìm 2 chữ số đầu và 2 chữ số cuối
// Cho một số nguyên có 3 chữ số
// In ra 2 chữ số đầu và 2 chữu số cuối của số vừa nhập
using System;
namespace TimChu
{
    class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            int chusodau = n / 10;
            int chusocuoi = n % 100;
            string chudauStr = chudau.ToString();
            string chucuoiStr = chucuoi.ToString("D2");
            Console.Write(chusodau + " " + chusocuoi);
        }
    }
}