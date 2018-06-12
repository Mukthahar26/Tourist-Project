using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class updatetrain : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        f1();
        if (!IsPostBack)
        {
            con.Open();
            SqlCommand da = new SqlCommand("select *from train where id=" + id + "", con);
            SqlDataReader dr = da.ExecuteReader();
            if (dr.Read())
            {
                tno.Text = dr["no"].ToString();
                tname.Text = dr["name"].ToString();
                dep.Text = dr["source"].ToString();
                deptime.Text = dr["departure"].ToString();
                arr.Text = dr["destination"].ToString();
                arrtime.Text = dr["arrival"].ToString();
                coveringroutes.Text = dr["runon"].ToString();
            }
            con.Close();
        }
    }
    private void f1()
    {
        con.Open();
        SqlCommand da = new SqlCommand("select id from train where name='" + Session["name"] + "'", con);
        SqlDataReader dr = da.ExecuteReader();
        if (dr.Read())
        {
            id = Convert.ToInt32(dr["id"]);
        }
        con.Close();
    }
    protected void submit_click(object sender, EventArgs e)
    {
        if ((tno.Text != "") && (dep.Text != "") && (deptime.Text != "") && (arr.Text != "") && (arrtime.Text != "") && (coveringroutes.Text != ""))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update train set no='" + tno.Text + "',source='" + dep.Text + "',departure='" + deptime.Text + "',destination='" + arr.Text + "',arrival='" + arrtime.Text + "',runon='" + coveringroutes.Text + "' where id=" + id + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Success";
        }
        else
        {
            Label1.Text = "Please Insert All Fields";
        }
    }
}