// In ra các chữ số lẻ của một số có 8 chữ số
using System;
namespace InRaSoLe
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string ketQua = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                int digit = a[i] - '0';
                if (digit % 2 == 1)
                {
                    if(ketQua == "")
                    ketQua = digit.ToString();
                    else 
                    ketQua += " " + digit.ToString();
                } 
            }
            if (ketQua == "")
            Console.Write("-");
            else 
            Console.Write(ketQua);
        }
    }
}