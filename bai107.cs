//Kiểm tra n có phỉa là số nguyên tố
using System;
namespace NguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dem = 0;
            for(int i = 1; i <= n; i++)
            {
            if(n % i == 0)
            {
                dem++;
            } 
            }
            if (dem == 2)
            {
                Console.Write("Yes");
            } else
            {
                Console.Write("No");
            }
        }
    }
}