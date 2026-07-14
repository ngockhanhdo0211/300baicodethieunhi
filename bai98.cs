// Tìm số chia hết cho 3 mà không chia hết cho 9 thứ k
using System;
namespace TimSo
{
    class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int dem = 0;
            for (int i = 1; ; i++)
            {
                if (i % 3 == 0 && i % 9 != 0)
                {
                    dem++;

                    if (dem == k)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }
}