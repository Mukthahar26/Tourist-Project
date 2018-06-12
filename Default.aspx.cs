using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        con.Open();
        SqlCommand da = new SqlCommand("select id from bus", con);
        GridView1.DataSource = da.ExecuteReader();
        GridView1.DataBind();
        con.Close();
       
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        DropDownList ddl;
        foreach (GridViewRow row in GridView1.Rows)
        {
            ddl = (DropDownList)row.FindControl("ddl");
            con.Open();
            SqlCommand da = new SqlCommand("select id from bus", con);
            ddl.DataSource = da.ExecuteReader();
            ddl.DataBind();
            con.Close();
        }
    }
}