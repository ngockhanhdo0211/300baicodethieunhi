// Đánh giá kết quả học tập theo tổng diểm
using System;
namespace TongDiem
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            string loai, mota;
            if (d >= 80) loai = "Loai A";
            else if (d >= 50) loai = "Loai B";
            else loai = "Loai C";
            if (d >= 90) mota = "Xuat sac";
            else if (d >= 80) mota = "Gioi";
            else if (d >= 65) mota = "Kha";
            else if (d >= 50) mota = "Trung binh";
            else if (d >= 35) mota = "Yeu";
            else mota = "Kem";
            Console.WriteLine(loai);
            Console.WriteLine(mota);
        }
    }
}