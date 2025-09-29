using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenAnhKhoi_1150080141
{
    internal class bt_TH6
    {
        public static void Main(string[] args)
        {
            double chieuDai, chieuRong;

            Console.Write("Nhap vao chieu dai cua hinh chu nhat: ");
            while (!double.TryParse(Console.ReadLine(), out chieuDai) || chieuDai <= 0)
            {
                Console.WriteLine("Chieu dai khong hop le. Vui long nhap mot so thuc duong.");
                Console.Write("Nhap lai chieu dai: ");
            }

            Console.Write("Nhap vao chieu rong cua hinh chu nhat: ");
            while (!double.TryParse(Console.ReadLine(), out chieuRong) || chieuRong <= 0)
            {
                Console.WriteLine("Chieu rong khong hop le. Vui long nhap mot so thuc duong.");
                Console.Write("Nhap lai chieu rong: ");
            }

            double chuVi = (chieuDai + chieuRong) * 2;
            double dienTich = chieuDai * chieuRong;

            Console.WriteLine($"Chu vi cua hinh chu nhat la: {chuVi}");
            Console.WriteLine($"Dien tich cua hinh chu nhat la: {dienTich}");

            Console.ReadKey();
        }
    }
}