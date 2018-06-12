using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Transport : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    int n;
    String count;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            tnoo.Visible = false;
            depp.Visible = false;
            arrr.Visible = false;
            bnoo.Visible = false;
            btypee.Visible = false;
            fromm.Visible = false;
            too.Visible = false;
            coverr.Visible = false;
            publishh.Visible = false;
            f3();
        }
        categ();
    }
    private void f3()
    {
        con.Open();
        SqlCommand cmd2 = new SqlCommand("select subcategory from Category where category='" + "Transport" + "' order by subcategory asc", con);
        services.DataSource = cmd2.ExecuteReader();
        services.DataTextField = "subcategory";
        services.DataBind();
        con.Close();
        
    }
    private void categ()
    {
        if (services.SelectedItem + "" == "Bus")
        {
            n = 1;
            f1();
            tnoo.Visible = false;
            depp.Visible = false;
            arrr.Visible = false;
            depp.Visible = false;
            runonn.Visible = false;
            bnoo.Visible = true;
            btypee.Visible = true;
            fromm.Visible = true;
            too.Visible = true;
            coverr.Visible = true;
            publishh.Visible = true;
            Label1.Text = "";
            
        }
        if (services.SelectedItem + "" == "Train")
        {
            n = 2;
            f1();
            tnoo.Visible = true;
            depp.Visible = true;
            arrr.Visible = true;
            depp.Visible = true;
            runonn.Visible = true;
            bnoo.Visible = false;
            btypee.Visible = false;
            fromm.Visible = false;
            too.Visible = false;
            coverr.Visible = false;
            publishh.Visible = true;
            Label1.Text = "";
        }
    }
    protected void publish_Click(object sender, EventArgs e)
    {
        if ((bno.Text != "") && (RadioButtonList1.SelectedItem + "" != "") && (to.Text != "") && (from.Text != "") && (coveringroutes.Text != ""))
        {
            if (n == 1)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into bus values(" + count + ",'" + "Transport" + "','" + services.SelectedItem + "" + "','" + bno.Text + "','" + RadioButtonList1.SelectedItem + "','" + from.Text + "','" + to.Text + "','" + coveringroutes.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Label1.Text = "Success";
            }
        }
        else
            Label1.Text = "Please Fill all Bus Fields";

        if ((tno.Text != "") && (dep.Text != "") && (arr.Text != "") && (runon.Text != ""))
        {
            if (n == 2)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into train values(" + count + ",'" + "Transport" + "','" + services.SelectedItem + "" + "','" + tno.Text + "','" + dep.Text + "''" + arr.Text + "','" + runon.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Label1.Text = "Success";
            }
        }
        else
            Label1.Text = "Please fill all Train Fields";
    }
    private void f1()
    {
        count = Class1.GetRandomPassword();
    }
}