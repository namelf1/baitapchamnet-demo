using System;
using System.Collections.Generic;
using System.Text;

namespace lib_HinhHoc
{
    public class HinhVuong
    {
        //input
        public double a;
        //output
        public double chuvi { get; private set; }

        public bool ok { get; private set; }
        public void XuLy()
        {
            //phần tính toán
            if (a > 0)
            {
                chuvi = a * 4;
                ok = true;
            }
            else
            {
                ok = false;
            }
        }
    }
}
