using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class busview : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["page"] == null)
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select *from bus", con);
                da.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                con.Close();
            }
            else
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select *from bus where fromroute like '%" + Session["page"] + "%' or toroute like '%" + Session["page"] + "%' or busno like '%" + Session["page"] + "%' or coveringroutes like '%" + Session["page"] + "%'", con);
                da.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                con.Close();
                Session["page"] = null;
            }
        }
    }

    protected void GridView1_Load(object sender, EventArgs e)
    {
        if (GridView1.Rows.Count <= 0)
        {
            border.Visible = true;
        }
        else
            border.Visible = false;
    }

    protected void search_click(object sender, EventArgs e)
    {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select *from bus where fromroute like'%" + to.Text + "%' or toroute like '%" + to.Text + "%' or coveringroutes like '%"+to.Text+"%'", con);
        da.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();

        if (GridView1.Rows.Count <= 0)
        {
            border.Visible = true;
        }
        else
            border.Visible = false;
    }
}