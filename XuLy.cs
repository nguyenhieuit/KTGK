using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace KT_GiuaKi
{
    public class XuLy: System.Web.UI.Page
    {
        SqlConnection cnn;
        public void Opencnn()
        {
            string link = Page.Server.MapPath("App_Data");
            link += "\\QL_Sach.mdf";
            cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + link + ";Integrated Security=True");
            cnn.Open();
        }
        public void Closecnn()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public DataTable load_data( string sql)
        {
            DataTable dt = new DataTable(); 
            try
            {
                Opencnn();
                SqlDataAdapter dataADP = new SqlDataAdapter(sql, cnn);
                dataADP.Fill(dt);
            }
            catch 
            {
                dt = null;
            }
            finally
            {
                Closecnn();
            }
            return dt;
        }
    }
}