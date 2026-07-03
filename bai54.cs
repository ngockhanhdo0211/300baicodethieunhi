// Kiểm tra tuổi của một người đang ở giai đoạn nào 
using System;
namespace KiemTraTuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string loai, mota;
            if (t < 18) loai = "Tre em";
            else if (t >= 18 && t <60) loai = "Nguoi truong thanh";
            else loai = "Nguoi cao tuoi";
            if(t <= 6) mota = "Tre mam non";
            else if (t >= 7 && t <= 11) mota = "Tre tieu hoc";
            else if (t >= 12 && t <= 17) mota = "Tre trung hoc";
            else if (t >= 18 && t <= 23) mota = "Sinh vien";
            else if (t >= 24 && t < 60) mota = "Nguoi di lam";
            else if (t >= 60 && t <= 62) mota = "Sap nghi huu";
            else mota = "Da nghi huu";
            Console.WriteLine(loai);
            Console.WriteLine(mota);
        }
    }
}