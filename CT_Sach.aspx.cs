using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace KT_GiuaKi
{
    public partial class CT_Sach : System.Web.UI.Page
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\KTTMDT\KT_GiuaKi\KT_GiuaKi\App_Data\QL_Sach.mdf;Integrated Security=True";
        XuLy KN = new XuLy();
        protected void Page_Load(object sender, EventArgs e)
        {
            load_Sach();
        }
        public void load_Sach()
        {
            if (Page.IsPostBack) return;
            string sql;
            if (Context.Items["MS"] == null)
                sql = "Select *From Sach";
            else
            {
                string masach = Context.Items["MS"].ToString();
                sql = "Select *From Sach where MaSach='" + masach + "'";
            }
            try
            {
                this.DataList1.DataSource = KN.load_data(sql);
                this.DataList1.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        /*protected void Button1_Click(object sender, EventArgs e)
        {
            Button muasach = ((Button)sender);
            string masach = muasach.CommandArgument.ToString();
            string makh = muasach.CommandArgument.ToString();
            DataListItem item = (DataListItem)muasach.Parent;
            string SL = ((TextBox)item.FindControl("txt_sl")).Text;
            if (Request.Cookies["TenDN"] == null) return; //Kiểm tra đăng nhập
            string tendn = Request.Cookies["TenDN"].Value;
            SqlConnection cnn = new SqlConnection(link);
            cnn.Open();
            string sql = "Select *From Sach, KhachHang " + "Where KhachHang.TenDN='" + tendn + "' and MaSach='" + masach + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            SqlDataReader read = cmm.ExecuteReader();
            if (read.Read())
            {
                read.Close();
                cmm=new SqlCommand("Update DonHang set Soluong = Soluong + " + SL + " Where TenDN='" + tendn + "' AND MaSP='" + masach + "'", cnn);
            }
            else
            {
                read.Close();
                cmm = new SqlCommand("Insert into DonHang" + "(MaKH, MaSSach, SoLuong) values('" + makh + "', '" + masach + "', '" + SL + "')", cnn);
            }
            cmm.ExecuteReader();
            cnn.Close();
        }*/
    }
}