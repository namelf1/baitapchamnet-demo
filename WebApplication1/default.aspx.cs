using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TextBox1.Text);

            lib_HinhHoc.HinhVuong hv = new lib_HinhHoc.HinhVuong();
            hv.a = a;
            hv.XuLy();
            if (hv.ok)
            {
                ketqua_web.InnerHtml= $"Chu vi hình vuông = {hv.chuvi}";
            }
            else
            {
                ketqua_web.InnerHtml= "Lỗi: Độ dài cạnh của hình vuông phải lớn hơn 0.";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}