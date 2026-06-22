// Dòng một: một số nguyên a.
// Dòng hai: Hai số nguyên b và c, cách nhau bởi một dấu cách 
using System;
namespace baiTap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int b = int.Parse(s[0]);
            int c = int.Parse(s[1]);
            int result = a + b - c;
            Console.WriteLine(result);
            // // int a = int.Parse(Console.ReadLine());
            // // int b = int.Parse(Console.ReadLine());
            // // int c = int.Parse(Console.ReadLine());
            // string d = "232323 3231154";
            // Console.WriteLine(d[0]);

            // // int ketQua = a + b -c;
            // // Console.WriteLine(ketQua);

        }
     }
}