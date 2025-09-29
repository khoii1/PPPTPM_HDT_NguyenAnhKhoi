using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenAnhKhoi_1150080141
{
    internal class bt_TH7
    {
        public static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Nhap vao do dai canh a: ");
            while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Do dai khong hop le. Vui long nhap mot so thuc duong.");
                Console.Write("Nhap lai do dai canh a: ");
            }

            Console.Write("Nhap vao do dai canh b: ");
            while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Do dai khong hop le. Vui long nhap mot so thuc duong.");
                Console.Write("Nhap lai do dai canh b: ");
            }

            Console.Write("Nhap vao do dai canh c: ");
            while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
            {
                Console.WriteLine("Do dai khong hop le. Vui long nhap mot so thuc duong.");
                Console.Write("Nhap lai do dai canh c: ");
            }

            if (a + b > c && a + c > b && b + c > a)
            {
                double chuVi = a + b + c;

               
                double p = chuVi / 2;
                double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine("Ba canh da nhap tao thanh mot tam giac.");
                Console.WriteLine($"Chu vi cua tam giac la: {chuVi}");
                Console.WriteLine($"Dien tich cua tam giac la: {dienTich}");
            }
            else
            {
                Console.WriteLine("Ba canh da nhap khong the tao thanh mot tam giac.");
            }

            Console.ReadKey();
        }
    }
}