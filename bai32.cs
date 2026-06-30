// Nhập vào điểm trung bình của hai bạn AN và Bình
// Nếu hai bạn bằng điểm trung bình thì in ra " Bằng nhau"
using System;
namespace SoSanh
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("An gioi hon");
            }
            if (a < b)
            {
                Console.WriteLine("Binh gioi hon");
            }
            if (a == b)
            {
                Console.WriteLine("Bang nhau");
            }
        }
    }
}