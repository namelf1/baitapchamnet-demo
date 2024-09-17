using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //
            string kq = "";
            try
            {
                double a = Convert.ToDouble(this.Request.Form["a"]);

                lib_HinhHoc.HinhVuong hv = new lib_HinhHoc.HinhVuong();
                hv.a = a;
                hv.XuLy();


                if (hv.ok)
                {
                    kq = $"Chu vi hình vuông = {hv.chuvi}";
                }
                else
                {
                    kq = "Lỗi: Độ dài cạnh của hình vuông phải lớn hơn 0.";
                }
            } catch (Exception ex)
            {
                kq=$"Lỗi: {ex.Message}";
            }
            finally
            {
                this.Response.Write(kq);
            }
            
        }
    }
    
}