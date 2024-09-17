using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bài toán tính chu vi hình vuông
            //tách phần tính ra hàm
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tính chu vi hình vuông - ConsoleApp2");
            Console.Write("Nhập chiều dài một cạnh của hình vuông: ");
            double a = Convert.ToDouble(Console.ReadLine());

            double p = 0;
            bool ok = XuLy(a, ref p);
            if (ok)
            {
                Console.WriteLine($"Chu vi hình vuông = {p}");
            }
            else
            {
                Console.WriteLine("Lỗi: Độ dài cạnh của hình vuông phải lớn hơn 0.");
            }
            Console.ReadKey();
        }

        static bool XuLy(double a, ref double p) 
        {
            //phần tính toán
            if (a > 0)
            {
                p = a * 4;
                //Console.WriteLine($"Chu vi hình vuông = {p}");
                return true;
            }
            else
            {
                //Console.WriteLine("Lỗi: Độ dài cạnh của hình vuông phải lớn hơn 0.");
                return false;
            }
        }
    }
}
