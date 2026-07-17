// In các số nguyên tố từ m đến n
using System;
namespace SoNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

bool coSoNguyenTo = false;

for (int i = m; i <= n; i++)
{
    bool laNguyenTo = true;

    if (i < 2)
    {
        laNguyenTo = false;
    }
    else
    {
        for (int j = 2; j * j <= i; j++)
        {
            if (i % j == 0)
            {
                laNguyenTo = false;
                break;
            }
        }
    }

    if (laNguyenTo)
    {
        
    }
}

if (!coSoNguyenTo)
{
    Console.Write("-");
}
        }
    }
}