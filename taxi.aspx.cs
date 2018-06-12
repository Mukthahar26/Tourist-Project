using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class taxi : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            f1();
        }       
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        if (filter.SelectedItem + "" == "None")
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from taxi", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
            con.Close();
        }
        else
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from taxi where name='" + filter.SelectedItem + "" + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
            con.Close();
        }
    }

  
    private void f1()
    {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select name from taxi group by name", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        filter.DataSource = ds;
        filter.DataTextField = "name";
        filter.DataBind();
        con.Close();
    }

    protected void sms_click(object sender, EventArgs e)
    {
        Button b1 = (Button)sender;
        DataListItem item = (DataListItem)b1.NamingContainer;

        HtmlGenericControl name = (HtmlGenericControl)item.FindControl("name");
        HtmlGenericControl owner = (HtmlGenericControl)item.FindControl("owner");
        HtmlGenericControl contact = (HtmlGenericControl)item.FindControl("contact");
 
        Session["taxiname"] = name.InnerText;
        Session["taxiowner"] = owner.InnerText;
        Session["contact"] = contact.InnerText;

        if (Session["user"] == null)
        {
            Session["nouser"] = "true";
            Response.Redirect("loginuser.aspx");
        }
        else
        {
            Response.Redirect("taxiconfirmation.aspx");
        }
    }
}