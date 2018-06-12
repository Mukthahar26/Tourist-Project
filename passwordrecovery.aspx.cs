using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

public partial class passwordrecovery : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlGenericControl search = (HtmlGenericControl)Master.FindControl("search");
        search.Visible = false;   
    }
    protected void save_Click(object sender, EventArgs e)
    {
        if (password.Text != "" || confirmpassword.Text != "")
        {
            if (password.Text == confirmpassword.Text)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update login set password='" + password.Text + "', confirmpassword='" + confirmpassword.Text + "' where email='" + Session["email"] + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Label1.Text = "Password Reset Successfully";
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "5;url=loginuser.aspx";
                this.Page.Controls.Add(meta);
            }
            else
                Label1.Text = "Password not Matched";
        }
        else
            Label1.Text="Please Enter Password";
    }
}