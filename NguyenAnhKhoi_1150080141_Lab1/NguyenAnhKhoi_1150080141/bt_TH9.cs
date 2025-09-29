using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenAnhKhoi_1150080141
{
    internal class bt_TH9
    {
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong phan tu cua mang: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("So luong khong hop le. Vui long nhap mot so nguyen duong.");
                Console.Write("Nhap lai so luong phan tu: ");
            }

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Gia tri khong hop le. Vui long nhap mot so nguyen.");
                    Console.Write($"Nhap lai phan tu thu {i + 1}: ");
                }
            }

            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }

            Console.WriteLine($"Tong cac phan tu trong mang la: {sum}");

            Console.ReadKey();
        }
    }
}