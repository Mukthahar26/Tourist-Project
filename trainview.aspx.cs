using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class trainview : System.Web.UI.Page
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
                SqlDataAdapter da = new SqlDataAdapter("select *from train", con);
                da.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                con.Close();
            }
            else
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select *from train where no like '%" + Session["page"] + "%' or source like '%" + Session["page"] + "%' or destination like '%" + Session["page"] + "%' or no like '%" + Session["page"] + "%'", con);
                da.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                con.Close();
                Session["page"] = null;
            }
        }
    }
    
    protected void GridView1_Load1(object sender, EventArgs e)
    {
        if (GridView1.Rows.Count < 1)
        {
            border.Visible = true;
        }
    }

    protected void search_click(object sender, EventArgs e)
    {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select *from train where source like '%" + from.Text + "%' or destination like '%" + from.Text + "%' or runon like '%" + from.Text + "%'", con);
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
