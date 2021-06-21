using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace KT_GiuaKi
{
    public partial class layer : System.Web.UI.MasterPage
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\KTTMDT\KT_GiuaKi\KT_GiuaKi\App_Data\QL_Sach.mdf;Integrated Security=True";
        XuLy KN = new XuLy();
        protected void Page_Load(object sender, EventArgs e)
        {
            load_DL();
        }
        public void load_DL()
        {
            string sql = "Select *From LoaiSach";
            DataList1.DataSource = KN.load_data(sql);
            this.DataList1.DataBind();
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string username = this.Login1.UserName;
            string password = this.Login1.Password;
            string sql="Select *From KhachHang Where TenDN='"+username+"' and MatKhau = '"+password+"'";
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, link);
                da.Fill(dt);
            }
            catch (SqlException err)
            {
                Response.Write("<b>Error</b>" + err.Message + "<p/>");
            }
            if (dt.Rows.Count != 0)
            {
                Response.Cookies["TenDN"].Value = username;
                Server.Transfer("SongNgu.aspx");
            }
            else
            {
                this.Login1.FailureText = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            String maloai = ((LinkButton)sender).CommandArgument;
            Context.Items["ML"] = maloai;
            Server.Transfer("SongNgu.aspx");
        }
    }
}