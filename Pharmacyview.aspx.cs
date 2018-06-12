using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Pharmacyview : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            f1();
        }
        if (Session["page"] == null)
        {
            if (filter.SelectedItem + "" == "None")
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select *from pharmacy", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
            }
            else
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select *from pharmacy where street='" + filter.SelectedItem + "" + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
            }
        }
        else
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from pharmacy where name like '%"+Session["page"]+"%'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
            con.Close();
            Session["page"] =null;
        }
    }
    private void f1()
    {
        con.Open();
        SqlDataAdapter da1 = new SqlDataAdapter("select street from pharmacy group by street", con);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        filter.DataSource = ds1;
        filter.DataTextField = "street";
        filter.DataBind();
        con.Close();
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