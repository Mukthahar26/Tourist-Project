using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class name : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select username from message where username !='" + "admin" + "' group by username", con);
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
            con.Close();
        }
    }
    protected void username_click(object sender, EventArgs e)
    {
        LinkButton name = (LinkButton)sender;
        DataListItem item = (DataListItem)name.NamingContainer;

        LinkButton username = (LinkButton)item.FindControl("username");

        Session["username"] = username.Text;
        Response.Redirect("adminchat.aspx");
    }
}