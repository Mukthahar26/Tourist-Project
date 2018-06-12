using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class updatebus : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        f1();
        if (!IsPostBack)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from bus where id=" + id + "", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                bno.Text = dr["busno"].ToString();
                RadioButtonList1.Items.FindByText(dr["bustype"].ToString()).Selected = true;
                from.Text = dr["fromroute"].ToString();
                deptime.Text = dr["departure"].ToString();
                to.Text = dr["toroute"].ToString();
                arrtime.Text = dr["arrival"].ToString();
                coveringroutes.Text = dr["coveringroutes"].ToString();
            }
            con.Close();
        }
    }

    protected void submit_click(object sender, EventArgs e)
    {
        if ((bno.Text != "") && (RadioButtonList1.SelectedItem + "" != "") && (from.Text != "") && (deptime.Text != "") && (to.Text != "") && (arrtime.Text != "") && (arrtime.Text != "") && (coveringroutes.Text != ""))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update bus set busno='" + bno.Text + "', bustype='" + RadioButtonList1.SelectedItem + "" + "', fromroute='" + from.Text + "',departure='" + deptime.Text + "', toroute='" + to.Text + "', arrival='" + arrtime.Text + "', coveringroutes='" + coveringroutes.Text + "' where id=" + id + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Success";
        }
        else
        {
            Label1.Text = "Please Fill all TextBoxes";
        }
    }

    private void f1()
    {
        con.Open();
        SqlCommand da = new SqlCommand("select id from bus where busno='" + Session["busno"] + "'", con);
        SqlDataReader dr = da.ExecuteReader();
        if (dr.Read())
        {
            id = Convert.ToInt32(dr["id"]);
        }
        con.Close();
    }
}