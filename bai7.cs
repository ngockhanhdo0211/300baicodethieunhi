// Căn bậc 2 
// cho một số thực không âm a,  hãy tính kết quả B = căn bậc 2 của a 
using System;
namespace CanBac
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double B = Math.Sqrt(a);
            Console.WriteLine($"{B:F2}");
        }
    }
}