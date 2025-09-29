using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenAnhKhoi_1150080141
{
    internal class bt_TH11
    {
        public static void Main(string[] args)
        {
            string directoryPath = "bt_TH11_data";
            string filePath = Path.Combine(directoryPath, "input_array.txt");

            try
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                if (!File.Exists(filePath))
                {
                    File.WriteAllText(filePath, "64 25 12 22 11");
                    Console.WriteLine($"Da tao tep mau tai: {Path.GetFullPath(filePath)}");
                }

                string fileContent = File.ReadAllText(filePath);
                int[] arr = fileContent.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();

                Console.WriteLine("Mang ban dau:");
                PrintArray(arr);

                SelectionSort(arr);

                Console.WriteLine("\nMang sau khi sap xep:");
                PrintArray(arr);

                Console.Write("\nNhap so nguyen de chen vao mang: ");
                int valueToInsert;
                while (!int.TryParse(Console.ReadLine(), out valueToInsert))
                {
                    Console.WriteLine("Gia tri khong hop le. Vui long nhap mot so nguyen.");
                    Console.Write("Nhap lai so de chen: ");
                }

                arr = InsertIntoSortedArray(arr, valueToInsert);

                Console.WriteLine("\nMang sau khi chen:");
                PrintArray(arr);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Da xay ra loi: {ex.Message}");
            }

            Console.ReadKey();
        }

        public static int[] InsertIntoSortedArray(int[] sortedArray, int valueToInsert)
        {
            int n = sortedArray.Length;
            int[] newArray = new int[n + 1];
            int i = 0;

            while (i < n && sortedArray[i] < valueToInsert)
            {
                newArray[i] = sortedArray[i];
                i++;
            }

            newArray[i] = valueToInsert;

            while (i < n)
            {
                newArray[i + 1] = sortedArray[i];
                i++;
            }

            return newArray;
        }

        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                }

                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

        public static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}