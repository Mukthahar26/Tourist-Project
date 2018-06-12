using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class fastfoodview : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["page"] == null)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from Food where subcategory='" + "Fast Food" + "'", con);
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
            con.Close();
        }
        else
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from Food where subcategory='" + "Fast Food" + "' and name like '%"+Session["page"]+"%'", con);
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
            con.Close();
            Session["page"] = null;
        }
    }
    protected void comment_Click(object sender, EventArgs e)
    {
        LinkButton BuyNowButton = (LinkButton)sender;
        DataListItem item = (DataListItem)BuyNowButton.NamingContainer;
        Label lb = (Label)item.FindControl("Label1");
        Label NameLabel = (Label)item.FindControl("name");
        Session["name"] = NameLabel.Text;
        Server.Transfer("comment.aspx");
    }
    protected void DataList1_Load(object sender, EventArgs e)
    {
        if (DataList1.Items.Count < 1)
        {
            border.Visible = true;
        }
    }
}