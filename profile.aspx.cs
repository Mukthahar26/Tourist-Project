using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;

public partial class profile : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Server.Transfer("loginuser.aspx");
        }
        if (!IsPostBack)
        {
            con.Open();
            SqlCommand da = new SqlCommand("select *from login where username='" +Session["user"] + "'", con);
            SqlDataReader dr = da.ExecuteReader();
            if (dr.Read())
            {
                fname.InnerText = dr["firstname"].ToString();
                lname.InnerText = dr["lastname"].ToString();
                username.InnerText = dr["username"].ToString();
                email.InnerText = dr["email"].ToString();
                phone.InnerText = dr["phone"].ToString();
                gender.InnerText = dr["gender"].ToString();
                pro.InnerText = dr["professionality"].ToString();
                if (gender.InnerText == "")
                {
                    gender.InnerText = "Not Specified";
                }
                if (pro.InnerText == "")
                {
                    pro.InnerText = "Not Specified";
                }
            }
            con.Close();
        }
    }    
}