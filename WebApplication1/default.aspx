<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="2">
                        Web V1: Tính chu vi hình vuông
                    </td>
                </tr>
                <tr>
                    <td>Nhập độ dài cạnh hình vuông: </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                 <td></td>
                 <td>
                    <asp:Button ID="Button1" runat="server" Text="Tính chu vi" OnClick="Button1_Click" />

                  </td>
                </tr> 
                    <tr>
     <td colspan="2" id="ketqua_web" runat="server"></td>
     
    </tr> 
            </table>
        </div>
        <p>
        </p>
    </form>
</body>
</html>
