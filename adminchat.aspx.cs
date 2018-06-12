using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class adminchat : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    int id = 123;
    protected void Page_Load(object sender, EventArgs e)
    {
        h1.InnerText = Session["username"].ToString();
        f1();
        if (!IsPostBack)
        {
            f2();
        }
    }

    protected void send_click(object sender, EventArgs e)
    {
        con.Open();
        foreach (DataListItem dl in dt.Items)
        {
            Label admin = (Label)dl.FindControl("adminid");
           
            SqlCommand cmd = new SqlCommand("insert into message values('" + "Admin" + "','" + DateTime.Now + "','" + message.Text + "'," + admin.Text + "," + Session["userid"] + ")", con);
            cmd.ExecuteNonQuery();
            
            Response.Redirect(Request.Url.AbsoluteUri);
        }
        con.Close();
    }

    protected void dt_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
        {
            HtmlGenericControl name = e.Item.FindControl("name") as HtmlGenericControl;
            HtmlGenericControl div1 = e.Item.FindControl("message") as HtmlGenericControl;
            HtmlGenericControl div2 = e.Item.FindControl("div1") as HtmlGenericControl;
            cont.Attributes.CssStyle.Add("bottom", "0px");
            if (name.InnerText == "Admin")
            {
                div2.Attributes.CssStyle.Add("margin-left", "140px");
                div1.Attributes.CssStyle.Add("float", "right");
                div1.Attributes.CssStyle.Add("color", "white");
                div2.Attributes.CssStyle.Add("float", "right");
                div1.Attributes.CssStyle.Add("background", "#008080");
            }
        }
    }

    private void f1()
    {
        con.Open();
        SqlCommand da = new SqlCommand("select userid from message where username='" + Session["username"] + "'", con);
        SqlDataReader dr = da.ExecuteReader();
        if (dr.Read())
        {
            Session["userid"] = Convert.ToInt32(dr["userid"]);
        }
        con.Close();
    }

    private void f2()
    {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select *from message where adminid=" + id + " and userid=" + Session["userid"] + " order by date", con);
        da.Fill(ds);
        dt.DataSource = ds;
        dt.DataBind();
        con.Close();
    }

    protected void GetTime(object sender, EventArgs e)
    {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select *from message where adminid=" + id + " and userid=" + Session["userid"] + " order by date", con);
        da.Fill(ds);
        dt.DataSource = ds;
        dt.DataBind();
        con.Close();
    }
}