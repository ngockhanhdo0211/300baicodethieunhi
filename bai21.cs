// Chia mía
// Nhập vào chiều dài a của một cây mía tình bằng cm
// Chia đều cây mía đó thành các đoạn có độ dài b cm
// Hỏi chia được nhiều nhất mấy đoạn
// Đoạn dư có độ dài bao nheieu cm
using System;
namespace ChiaMia
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int A = a / b;
            int B = a % b;
            Console.Write(A + " " + B);
        }
    }
}