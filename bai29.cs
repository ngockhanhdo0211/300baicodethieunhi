// Tính điểm trung bình
// Nhập vào điểm toán, văn, tiếng anh của một học sinh là các số thưucj
// Tính trung bình của học sinh đó 
// biết rằng điểm toán và văn hệ số 2
using System;
namespace TinhDiemTrungBinh
{
    class Program
    {
        static void Main(string[] args)
        {
            double Toan = double.Parse(Console.ReadLine());
            double Van = double.Parse(Console.ReadLine());
            double tiengAnh = double.Parse(Console.ReadLine());
            double TB = (Toan * 2 + Van * 2 + tiengAnh) / 5.0;
            Console.Write($"{TB:F1}");
        }
    }
}