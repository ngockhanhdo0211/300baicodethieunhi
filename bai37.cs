// Xếp loại học sinh
using System;
namespace XepLoai
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double HKI = int.Parse(input[0]);
            double HKII = int.Parse(input[1]);
            double TBCN = (HKI +HKII * 2) / 3;
            Console.WriteLine($"{TBCN:F1}");
            if (TBCN >= 8)
            Console.WriteLine("Gioi");
            else if (TBCN >= 6.5)
            Console.WriteLine("Kha");
            else if (TBCN >= 5.0)
            Console.WriteLine("Trung binh");
            else if (TBCN >= 3.5)
            Console.WriteLine("Yeu");
            else
            Console.WriteLine("Kem");
            


        }

    }
}