﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenAnhKhoi_1150080141
{
    internal class bt_TH3
    {
        public static void Main(string[] args)
        {
            // Nhập dữ liệu
            Console.Write("Nhap vao so nguyen a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so nguyen b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so nguyen c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            // Tìm số max
            int max;
            if (a >= b && a >= c)
            {
                max = a;
            }
            else if (b >= a && b >= c)
            {
                max = b;
            }
            else
            {
                max = c;
            }

            // Hiển thị kết quả
            Console.WriteLine("So lon nhat trong 3 so la: {0}", max);
            Console.ReadKey();
        }
    }
}