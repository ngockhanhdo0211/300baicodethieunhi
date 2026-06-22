// Cho hai số nguyên a và b.
// Tính P là kết quả của a chia b lấy phần nguyên
// Tính Q là kết quả của a chia b lấy phần dư
using System;
namespace PhepChia
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            double P = a / b;
            double Q = a % b;
            Console.Write(P +" "+ Q);
        }
    }
}