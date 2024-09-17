using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsHinhVuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = (double)numericUpDown1.Value;

            lib_HinhHoc.HinhVuong hv = new lib_HinhHoc.HinhVuong();
            hv.a = a;
            hv.XuLy();
            if (hv.ok)
            {
                label_kq.Text=$"Chu vi hình vuông = {hv.chuvi}";
            }
            else
            {
                label_kq.Text="Lỗi: Độ dài cạnh của hình vuông phải lớn hơn 0.";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
