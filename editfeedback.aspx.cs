using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class editfeedback : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    string str;
    int i;
    protected void Page_Load(object sender, EventArgs e)
    {
        str = Session["user"].ToString();
        HtmlGenericControl search = (HtmlGenericControl)Master.FindControl("search");
        search.Visible = false;
        if (!IsPostBack)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from quefeedback where username='" + str + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TextBox1.Text = dr["q1"].ToString();
                TextBox2.Text = dr["q2"].ToString();
                TextBox3.Text = dr["q3"].ToString();
                TextBox4.Text = dr["q4"].ToString();
                TextBox5.Text = dr["q5"].ToString();
                TextBox6.Text = dr["q6"].ToString();
            }
        }
    }
    protected void submit_click(object sender, EventArgs e)
    {
        if ((TextBox1.Text != "") && (TextBox2.Text != "") && (TextBox3.Text != "") && (TextBox4.Text != "") && (TextBox5.Text != "") && (TextBox6.Text != ""))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update quefeedback set q1='" + TextBox1.Text + "',q2='" + TextBox2.Text + "',q3='" + TextBox3.Text + "',q4='" + TextBox4.Text + "',q5='" + TextBox5.Text + "',q6='" + TextBox6.Text + "' where username='"+Session["user"]+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Attributes.CssStyle.Add("color", "green");
            Label1.Attributes.CssStyle.Add("font-style", "italic");
            Label1.Text = "Thank your for updating your Feedback. Please Wait. . .";
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "5;url=Start.aspx";
            this.Page.Controls.Add(meta);
        }
        else
        {
            Label1.Attributes.CssStyle.Add("color", "red");
            Label1.Attributes.CssStyle.Add("font-style", "italic");
            Label1.Text = "Please Enter all answers";
        }
    }
}