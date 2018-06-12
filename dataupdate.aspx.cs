using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using AjaxControlToolkit;

public partial class dataupdate : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        f1();
    }
    protected void home_click(object sender, EventArgs e)
    {
        Response.Redirect("adminhome.aspx");
    }

    protected void name_click(object sender, EventArgs e)
    {
        LinkButton BuyNowButton = (LinkButton)sender;
        DataListItem item = (DataListItem)BuyNowButton.NamingContainer;

        LinkButton name = (LinkButton)item.FindControl("name");
        LinkButton busno = (LinkButton)item.FindControl("busno");

        if (DropDownList6.SelectedIndex != 2)
        {
            Session["name"] = name.Text;
        }

        if (DropDownList6.SelectedIndex == 0)
        {
            Server.Transfer("updatetourism.aspx");
        }
        if (DropDownList6.SelectedIndex == 1)
        {
            Server.Transfer("updatebank.aspx");
        }
        if (DropDownList6.SelectedIndex == 2)
        {
            Session["busno"] = busno.Text;
            Server.Transfer("updatebus.aspx");
        }
        if (DropDownList6.SelectedIndex == 3)
        {
            Server.Transfer("updatecompany.aspx");
        }
        if (DropDownList6.SelectedIndex == 4)
        {
            Server.Transfer("updatefood.aspx");
        }
        if (DropDownList6.SelectedIndex == 5)
        {
            Server.Transfer("updatehotels.aspx");
        }
        if (DropDownList6.SelectedIndex == 6)
        {
            Server.Transfer("updatehospitals.aspx");
        }
        if (DropDownList6.SelectedIndex == 7)
        {
            Server.Transfer("updatepharmacy.aspx");
        }
        if (DropDownList6.SelectedIndex == 8)
        {
            Server.Transfer("updateshopping.aspx");
        }
        if (DropDownList6.SelectedIndex == 9)
        {
            Server.Transfer("updatetrain.aspx");
        }
        if (DropDownList6.SelectedIndex == 10)
        {
            Server.Transfer("taxiupdate.aspx");
        }
    }

    protected void f1()
    {
        switch (DropDownList6.SelectedIndex)
        {
            case 0:
                DataList2.DataSource = "";
                DataList2.DataBind();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select *from tourism order by name asc", con);
                da.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 1:
                DataList2.DataSource = "";
                DataList2.DataBind();
                con.Open();
                SqlDataAdapter da1 = new SqlDataAdapter("select *from banks order by name asc", con);
                da1.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 2:
                DataList1.DataSource = "";
                DataList1.DataBind();
                con.Open();
                SqlDataAdapter da2 = new SqlDataAdapter("select *from bus order by busno asc", con);
                da2.Fill(ds);
                DataList2.DataSource = ds;
                DataList2.DataBind();
                con.Close();
                break;
            case 3:
                DataList2.DataSource = "";
                DataList2.DataBind();
                con.Open();
                SqlDataAdapter da3 = new SqlDataAdapter("select *from company order by name asc", con);
                da3.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 4:
                DataList2.DataSource = "";
                DataList2.DataBind();
                con.Open();
                SqlDataAdapter da4 = new SqlDataAdapter("select *from Food order by name asc", con);
                da4.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 5:
                DataList2.DataSource = "";
                DataList2.DataBind();
                con.Open();
                SqlDataAdapter da5 = new SqlDataAdapter("select *from hotels order by name asc", con);
                da5.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 6:
                DataList2.DataSource = "";
                DataList2.DataBind();
                con.Open();
                SqlDataAdapter da6 = new SqlDataAdapter("select *from hospital order by name asc", con);
                da6.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 7:
                DataList2.DataSource = "";
                DataList2.DataBind();
                con.Open();
                SqlDataAdapter da7 = new SqlDataAdapter("select *from pharmacy order by name asc", con);
                da7.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 8:
                DataList2.DataSource = "";
                DataList2.DataBind();
                con.Open();
                SqlDataAdapter da8 = new SqlDataAdapter("select *from Shopping order by name asc", con);
                da8.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 9:
                DataList2.DataSource = "";
                DataList2.DataBind();
                con.Open();
                SqlDataAdapter da9 = new SqlDataAdapter("select *from train order by name asc", con);
                da9.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 10:
                DataList2.DataSource = "";
                DataList2.DataBind();
                con.Open();
                SqlDataAdapter da10 = new SqlDataAdapter("select *from taxi order by name asc", con);
                da10.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
        }
    }
    
}