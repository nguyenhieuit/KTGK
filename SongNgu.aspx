<%@ Page Title="" Language="C#" MasterPageFile="~/layer.Master" AutoEventWireup="true" CodeBehind="SongNgu.aspx.cs" Inherits="KT_GiuaKi.SongNgu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #Image3{

        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList2" runat="server" RepeatColumns="3" OnSelectedIndexChanged="DataList2_SelectedIndexChanged">
        <ItemTemplate>
            <div class="SP">
                <asp:Image ID="Image3" runat="server" Width="100px" Height="100px" ImageUrl='<%# "~/Images/" + Eval("Hinh") %>'/>
                <br />
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("TenSach") %>'></asp:Label>
                <div class="Gia">
                    <%# Eval("DonGia", "{0:0,0}") %>
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" CommandArgument='<%# Eval("MaSach") %>'>Chi tiết sách</asp:LinkButton>
                </div
                <div>
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
