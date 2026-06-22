// Nhập vào một số nguyên a có 2 chữ số.
// Tìm chữ số hàng đơn vị và chữ số hàng chục của số nguyên a.
using System;
namespace ChuSo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int A1 = a % 10;
            int A2 = a / 10;
            Console.Write(A1+ " " + A2);
        }
    }
}