using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class registration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "";
        con.Open();
        SqlCommand cmd1 = new SqlCommand("select count(*) from login where username='"+username.Text+"' and password='"+password.Text+"'", con);
        int i = Convert.ToInt32(cmd1.ExecuteScalar());
        if (i >= 1)
        {
            Label1.Text = "This User Name/Mail already exist";
            con.Close();
        }

        else
        {
            if (password.Text == confirmpassword.Text)
            {


                SqlCommand cmd = new SqlCommand("insert into login values('" + first.Text + "','" + last.Text + "','" + username.Text + "','" + mail.Text + "','" + password.Text + "','" + confirmpassword.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Server.Transfer("home.aspx");
            }

            else
            {
                con.Close();
                Label1.Text = "Password not matched";
            }
        }
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {

    }
}