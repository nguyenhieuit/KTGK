<%@ Page Title="" Language="C#" MasterPageFile="~/layer.Master" AutoEventWireup="true" CodeBehind="CT_Sach.aspx.cs" Inherits="KT_GiuaKi.CT_Sach" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CT_CSS.css" rel="stylesheet" />
    <style>
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <div id="tensach">
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenSach") %>'></asp:Label>
            </div>
            <div id="Noidung">
                <div id="img_Sach">
                    <asp:Image ID="Img_hinh" runat="server" Width="100px" ImageUrl='<%# "~/Images/"+Eval("Hinh") %>' />
                    <div>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("DonGia","{0:0,0}") %>'></asp:Label>
                    </div>
                </div>
                <div id="mota">
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("MoTa") %>'></asp:Label>
                    <%--<div>
                        <asp:TextBox ID="txt_sl" runat="server"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Text="Mua sách" OnClick="Button1_Click" />
                    </div>--%>
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
