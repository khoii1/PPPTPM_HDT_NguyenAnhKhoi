using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenAnhKhoi_1150080141
{
    internal class bt_TH8
    {
        public static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Giai phuong trinh bac 2: ax^2 + bx + c = 0");
            Console.Write("Nhap he so a: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("He so khong hop le. Vui long nhap mot so.");
                Console.Write("Nhap lai he so a: ");
            }

            Console.Write("Nhap he so b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("He so khong hop le. Vui long nhap mot so.");
                Console.Write("Nhap lai he so b: ");
            }

            Console.Write("Nhap he so c: ");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("He so khong hop le. Vui long nhap mot so.");
                Console.Write("Nhap lai he so c: ");
            }

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh co vo so nghiem.");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem.");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"Phuong trinh co mot nghiem: x = {x}");
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh co hai nghiem thuc phan biet:");
                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = {x2}");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Phuong trinh co nghiem kep: x1 = x2 = {x}");
                }
                else
                {
                    double phanThuc = -b / (2 * a);
                    double phanAo = Math.Sqrt(-delta) / (2 * a);
                    Console.WriteLine("Phuong trinh co hai nghiem phuc:");
                    Console.WriteLine($"x1 = {phanThuc} + {phanAo}i");
                    Console.WriteLine($"x2 = {phanThuc} - {phanAo}i");
                }
            }

            Console.ReadKey();
        }
    }
}