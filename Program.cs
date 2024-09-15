using System;
using System.Collections.Generic;
using System.Text;

namespace baitapchamnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //họ tên: Lương Thanh Nam
            //bắt đầu làm bài toán: chu vi hình vuông
            //input: chiều dài một cạnh hình vuông là số a thực
            //output: chu vi p của hình vuông hoặc báo lỗi
            //thuật toán:
            // 1.kiểm tra được đầu vào a là số dương
            // 2. tính chu vi p = a*4
            // 3. output là p hoặc báo lỗi nếu a<=0

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tính chu vi hình vuông");
            Console.Write("Nhập chiều dài cạnh của hình vuông: ");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Lỗi: Độ dài cạnh của hình vuông phải lớn hơn 0.");
            }
            else
            {
                // Tính chu vi
                double p = 4 * a;
                // Hiển thị chu vi
                Console.WriteLine("Chu vi của hình vuông là: " + p);
            }
            Console.ReadKey();
        }
    }
}
