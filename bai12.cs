// CHIA TÁO
// Cho số hs của một lớp (HS) và số táo trong rổ (T).
// Hãy chia đều số táo cho tất cả học sinh trong lớp.
// Hỏi mỗi bạn sẽ được bao nhiêu quả táo? Và còn dư lại bao nhiêu quả.
using System;
namespace ChiaTao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int T = int.Parse(input[0]);
            int HS = int.Parse(input[1]);
            int ketQua1 = T / HS;
            int ketQua2 = T % HS;
            Console.Write(ketQua1+ " " + ketQua2);
        }
    }
}