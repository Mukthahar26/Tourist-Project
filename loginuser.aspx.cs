using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

public partial class loginuser : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlGenericControl search = (HtmlGenericControl)Master.FindControl("search");
        search.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        int i;
        con.Open();
        SqlCommand cmd = new SqlCommand("select count(*) from login where email='" + username1.Text + "' and password='" + password1.Text + "'", con);
        i = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
        if (i >= 1)
        {
            if (Session["nouser"] == "true")
            {
                f1();
                Response.Redirect("taxiconfirmation.aspx");
            }
            f1();
            Server.Transfer("start.aspx");
        }
        else
        {
            Label1.Attributes.CssStyle.Add("color", "white");
            Label1.Text = "Invalid User Name/Password"; 
        }
    }
    private void f1()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select username,id from login where username='" + username1.Text + "' or email='"+username1.Text+"' and password='" + password1.Text + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Session["user"] = dr["username"].ToString();
            Session["uid"] = dr["id"].ToString();
        }
        con.Close();
    }
}