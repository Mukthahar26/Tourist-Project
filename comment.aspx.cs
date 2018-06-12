using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class comment : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlGenericControl search = (HtmlGenericControl)Master.FindControl("search");
        search.Visible = false;
        if (Session["user"]!=null)
        {
            if (!IsPostBack)
            {
                name.Text = Session["user"].ToString();
            }
        }
        Label1.Text="User Reviews on:"+Session["name"];
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select *from comment where postname='"+Session["name"]+"'", con);
        da.Fill(ds);
        DataList1.DataSource = ds;
        DataList1.DataBind();
        con.Close();
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into comment values('" + "Historical places" + "','" +Session["name"]+"','"+ name.Text + "','" + DateTime.Now + "','" + commentt.Text + "')", con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect(Request.Url.AbsoluteUri);
    }
    protected void delete_click(object sender, EventArgs e)
    {
       
    }
}