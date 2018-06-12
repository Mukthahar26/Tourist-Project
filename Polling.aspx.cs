using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class Polling : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    string str;
    int i;
    protected void Page_Load(object sender, EventArgs e)
    {
        str = Session["user"].ToString();
        HtmlGenericControl search = (HtmlGenericControl)Master.FindControl("search");
        search.Visible = false;
        f1();
    }

    protected void submit_click(object sender, EventArgs e)
    {
        if (i == 0)
        {
            if ((TextBox1.Text != "") && (TextBox2.Text != "") && (TextBox3.Text != "") && (TextBox4.Text != "") && (TextBox5.Text != "") && (TextBox6.Text != ""))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into quefeedback values('" + str + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Label1.Attributes.CssStyle.Add("color", "green");
                Label1.Attributes.CssStyle.Add("font-style", "italic");
                Label1.Text = "Thank your for your Feedback";
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "5;url=Start.aspx";
                this.Page.Controls.Add(meta);
            }

            else
            {
                Label1.Attributes.CssStyle.Add("color", "red");
                Label1.Attributes.CssStyle.Add("font-style", "italic");
                Label1.Text = "Please Fill all Text Field";
            }
        }
        else
        {
            Label1.Attributes.CssStyle.Add("color", "red");
            Label1.Attributes.CssStyle.Add("font-style", "italic");
            Label1.Text = "Sorry you already submitted you feedback.";
        }
    }

    private void f1()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select count(*) from quefeedback where username='" + str + "'", con);
        i = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
    }
}