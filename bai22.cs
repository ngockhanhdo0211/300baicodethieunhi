// Bài tính chu vi và diện tích hình vuông
using System;
namespace ChuVi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double cv = a * 4;
            double dt = a * a;
            Console.Write(cv + " " + dt);
        }
    }
}