<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Layer.aspx.cs" Inherits="KT_GiuaKi.Layer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css_layer.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="top_bgr">
            <asp:Image ID="Image1" runat="server" ImageUrl="./images/top_bgr.gif" Width="100%" Height="70px" />
        </div>
        <div class="menu">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Trangchu.aspx">Trang chủ</asp:HyperLink>
            <asp:HyperLink ID="HyperLink2" runat="server">Giới thiệu</asp:HyperLink>
            <asp:HyperLink ID="HyperLink3" runat="server">Sách tiếng Việt</asp:HyperLink>
            <asp:HyperLink ID="HyperLink4" runat="server">Sách tiếng Anh</asp:HyperLink>
            <asp:HyperLink ID="HyperLink5" runat="server">Song ngữ</asp:HyperLink>
            <asp:HyperLink ID="HyperLink6" runat="server">Liên hệ</asp:HyperLink>
        </div>
        <div class="anhbia">
            <div class="img_brg">
                <asp:Image ID="Image2" runat="server" ImageUrl="./Images/bgr_sach.jpg" Height="95px" Width="810px"/>
            </div>
            <div class="seach">
                <div class="timkiem">
                    <asp:Label ID="Label1" runat="server" Text="Tìm kiếm"></asp:Label>
                </div>
                <div class="timkiem_form">
                    <asp:TextBox ID="TextBox1" runat="server" Height="34px" Width="230px"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Tìm kiếm" Height="38px" />
                </div>
            </div>
        </div>
        <div class="ND">
            <div class="left">
                <h1>Danh mục các loại sách</h1>
            </div>
            <div class="mid">
            </div>
            <div class="login">
                <div class="tieudeKM">
                    <marquee direction=”right”>Khuyến mãi khi mua sách lên đến 30%</marquee>
                </div>
                <asp:Login ID="Login1" runat="server">
                </asp:Login>
            </div>
        </div>
        <div class="footer">
            <div class="bot">
                <h1>Nguyễn Hiếu Mã sinh viên: 24211202819</h1>
            </div>
        </div>
    </form>
</body>
</html>
