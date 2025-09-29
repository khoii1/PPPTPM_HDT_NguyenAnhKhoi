using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenAnhKhoi_1150080141
{
    internal class bt_TH10
    {
        public static void Main(string[] args)
        {
            string filePath = "input_array.txt";
            try
            {
                string fileContent = File.ReadAllText(filePath);
                int[] arr = fileContent.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();

                Console.WriteLine("Mang ban dau:");
                PrintArray(arr);

                SelectionSort(arr);

                Console.WriteLine("\nMang sau khi sap xep:");
                PrintArray(arr);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Loi: Khong tim thay tep tai '{Path.GetFullPath(filePath)}'.");
                Console.WriteLine("Vui long tao tep 'input_array.txt' trong thu muc bin\\Debug voi cac so nguyen cach nhau boi dau cach.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Da xay ra loi: {ex.Message}");
            }

            Console.ReadKey();
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