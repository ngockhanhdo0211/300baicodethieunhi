// Kiểm tra số nguyên có chia hết cho 6?
// Nhập vào một số nguyên n
// Kết quả Yes nếu chia hết cho 6, ngược lại là No
using System;
namespace ThuNghiem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 6 == 0)
            {
                Console.Write("Yes");
            } else
            {
                Console.Write("No");
            }
        }
    }
}