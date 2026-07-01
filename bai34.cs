// Bài chuyển số sang chữ
// Nhập một số nguyên từ 1 đến 10
// In ra chữ tiếng anh của số đó
using System;
namespace ChuyenDoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
             if ( n == 1 ) Console.WriteLine("One");
             if (n == 2) Console.WriteLine("Two");
             if (n == 3) Console.WriteLine("Three");
             if (n == 4) Console.WriteLine("Four");
             if (n == 5) Console.WriteLine("Five");
             if (n == 6) Console.WriteLine("Six");
             if (n == 7) Console.WriteLine("Seven");
             if (n == 8) Console.WriteLine("Eight");
             if (n == 9) Console.WriteLine("Nine");
             if (n == 10) Console.WriteLine("Ten");
        }
    }
}