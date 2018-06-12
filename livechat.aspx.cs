using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class livechat : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    int id = 123;
    protected void Page_Load(object sender, EventArgs e)
    {
        f2();
        f1();
        if (!IsPostBack)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select *from message where adminid=" + id + " and userid=" + Session["userid"] + " order by date", con);
                da.Fill(ds);
                dt.DataSource = ds;
                dt.DataBind();
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }

    protected void send_click(object sender, EventArgs e)
    {
        foreach (DataListItem dl in dt.Items)
        {
            Label admin = (Label)dl.FindControl("adminid");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into message values('" + Session["user"] + "','" + DateTime.Now + "','" + message.Text + "'," + admin.Text + "," + Session["userid"] + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect(Request.Url.AbsoluteUri);
        }
    }
    private void f1()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select userid from message where username='" + Session["user"] + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Session["userid"] = Convert.ToInt32(dr["userid"]);
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
            if(name.InnerText!="Admin")
            {
               div2.Attributes.CssStyle.Add("margin-left", "110px");
               div1.Attributes.CssStyle.Add("color", "white");
               div2.Attributes.CssStyle.Add("float", "right");
               div1.Attributes.CssStyle.Add("background", "#008080");
               
            }
        }
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
    private void f2()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select count(*) from message where userid='" + Session["uid"] + "'", con);
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
        if (i != 0)
        {

        }
        else
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("insert into message values('" + Session["user"] + "','" + DateTime.Now + "','" + "Helloo! How can I help You." + "'," + id + "," + Session["uid"] + ")", con);
            cmd1.ExecuteNonQuery();
            con.Close();
        }
    }
}

