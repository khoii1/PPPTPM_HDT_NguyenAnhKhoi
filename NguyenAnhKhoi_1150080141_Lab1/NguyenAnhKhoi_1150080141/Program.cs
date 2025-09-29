using NguyenAnhKhoi_1150080141;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Chon Chuong Trinh:");
        Console.WriteLine("1. Chay bai TH1");
        Console.WriteLine("2. Chay bai TH2");
        Console.WriteLine("3. Chay bai TH3");
        Console.WriteLine("4. Chay bai TH4");
        Console.WriteLine("5. Chay bai TH5");
        Console.WriteLine("6. Chay bai TH6");
        Console.WriteLine("7. Chay bai TH7");
        Console.WriteLine("8. Chay bai TH8");
        Console.WriteLine("9. Chay bai TH9");
        Console.WriteLine("10. Chay bai TH10");
        Console.WriteLine("10. Chay bai TH11");

        Console.Write("Lua chon chay bai thuc hanh so: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
            bt_TH1.Main(args);   
        else if (choice == 2)
            bt_TH2.Main(args);
        else if (choice == 3)
            bt_TH3.Main(args);
        else if (choice == 4)
            bt_TH4.Main(args);
        else if (choice == 5)
            bt_TH5.Main(args);
        else if (choice == 6)
            bt_TH6.Main(args);
        else if (choice == 7)
            bt_TH7.Main(args);
        else if (choice == 8)
            bt_TH8.Main(args);
        else if (choice == 9)
            bt_TH9.Main(args);
        else if (choice == 10)
            bt_TH10.Main(args);
        else if (choice == 11)
            bt_TH11.Main(args);
    }
}
