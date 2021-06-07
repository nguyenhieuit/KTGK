using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KT_GiuaKi
{
    public partial class SongNgu : System.Web.UI.Page
    {
        XuLy KN = new XuLy();
        protected void Page_Load(object sender, EventArgs e)
        {
            load_DL();
        }
        public void load_DL()
        {
            string sql = "Select *From Sach";
            DataList2.DataSource = KN.load_data(sql);
            this.DataList2.DataBind();
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            String masach = ((LinkButton)sender).CommandArgument;
            Context.Items["MS"] = masach;
            Server.Transfer("CT_Sach.aspx");
        }

        protected void DataList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}