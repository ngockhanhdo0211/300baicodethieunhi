//TÍNH TỔNG HÀNG ĐƠN VỊ VÀ HÀNG CHỤC
// Nhập vào hai số nguyên a và b
// Tính tổng hàng đơn vị của số nguyên a và hàng chục của số nguyên b
using System;
namespace TinhTong
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int Tong = a % 10 + b / 10;
            Console.Write(Tong);
        }
    }
}