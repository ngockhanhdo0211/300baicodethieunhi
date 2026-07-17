// Tính n giai thừa (n!)
using System;
namespace GiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ketQua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketQua *= i;
            
            }
            Console.Write(ketQua);
        }
    }
}