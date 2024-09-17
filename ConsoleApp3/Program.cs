using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bài toán tính chu vi hình vuông
            //tách phần tính ra Class (OOP)
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tính chu vi hình vuông - ConsoleApp2");
            Console.Write("Nhập chiều dài một cạnh của hình vuông: ");
            double a = Convert.ToDouble(Console.ReadLine());

            HinhVuong hv=new HinhVuong();
            hv.a = a;
            hv.XuLy();
            if (hv.ok)
            {
                Console.WriteLine($"Chu vi hình vuông = {hv.chuvi}");
            }
            else
            {
                Console.WriteLine("Lỗi: Độ dài cạnh của hình vuông phải lớn hơn 0.");
            }
            Console.ReadKey();
        }
    }
}
