// ba số nguyên trên một dòng, cách nhau bởi dấu cách theo thứ tự a,b,c
// Giá trị tuyệt đối của a,b,c không vượt quá 10^9
// Output: Số lớn nhất trong ba số
using System;
namespace SoLonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int max = a;
            if ( b > max) max = b;
            if (c > max ) max = c;
            Console.Write(max);
        }
    }
}