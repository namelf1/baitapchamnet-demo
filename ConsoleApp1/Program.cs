using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bài toán: Tính chu vi hình vuông
            //Họ tên: Lương Thanh Nam
            //input: 1 cạnh số thực của hình vuông
            //output: chu vi hình vuông hoặc báo lỗi
            //thuật toán:
            //1. Kiểm tra số a được nhập là số thực lớn hơn 0 hay không, thoả đk sang b2, không thì sang b3
            //2. Tính chu vi p=a*4,
            //   output là p
            //3. output: báo lỗi

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tính chu vi hình vuông - ConsoleApp1");
            Console.Write("Nhập chiều dài một cạnh của hình vuông: ");
            double a = Convert.ToDouble(Console.ReadLine());


            //phần tính toán
            if (a>0)
            {
                double p = a * 4;
                Console.WriteLine($"Chu vi hình vuông = {p}");
            }
            else
            {
                Console.WriteLine("Lỗi: Độ dài cạnh của hình vuông phải lớn hơn 0.");
            }
            //end

            Console.ReadKey();
        }
    }
}
