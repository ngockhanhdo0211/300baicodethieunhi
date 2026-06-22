// TÍNH TỔNG SỐ HÀNG ĐƠN VỊ
// Hai số nguyên a,b, hai số trên một dòng, cách nhau bởi dấu cách
// Tính tổng hàng đơn vị của hai số nguyên a và b.
using System;
namespace TinhDonVi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int Tong = a % 10 + b % 10;
            Console.Write(Tong);
        }
    }
}