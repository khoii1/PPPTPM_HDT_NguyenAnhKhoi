using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenAnhKhoi_1150080141
{
    internal class bt_TH1
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap vao chieu dai: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao chieu rong: ");
            double b = Convert.ToDouble(Console.ReadLine());

            //Tinh chu vi va dien tich
            double chuVi = (a + b) * 2;
            double dienTich = a * b;

            //Hien thi ket qua
            Console.WriteLine("Chu vi hinh chu nhat la: " + chuVi);
            Console.WriteLine("Dien tich hinh chu nhat la: " + dienTich);
        }
    }
}
