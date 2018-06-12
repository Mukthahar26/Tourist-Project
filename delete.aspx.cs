using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

public partial class delete : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    string table;
    protected void Page_Load(object sender, EventArgs e)
    {
        f1();
    }
    protected void home_click(object sender, EventArgs e)
    {
        Response.Redirect("adminhome.aspx");
    }
    protected void f1()
    {
        switch (DropDownList6.SelectedIndex)
        {
            case 0:
                DataList2.DataSource = "";
                DataList2.DataBind();
                table="tourism";
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select *from tourism", con);
                da.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 1:
                DataList2.DataSource = "";
                DataList2.DataBind();
                table="banks";
                con.Open();
                SqlDataAdapter da1 = new SqlDataAdapter("select *from banks", con);
                da1.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 2:
                DataList1.DataSource = "";
                DataList1.DataBind();
                table="bus";
                con.Open();
                SqlDataAdapter da2 = new SqlDataAdapter("select *from bus", con);
                da2.Fill(ds);
                DataList2.DataSource = ds;
                DataList2.DataBind();
                con.Close();
                break;
            case 3:
                DataList2.DataSource = "";
                DataList2.DataBind();
                table="company";
                con.Open();
                SqlDataAdapter da3 = new SqlDataAdapter("select *from company", con);
                da3.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 4:
                DataList2.DataSource = "";
                DataList2.DataBind();
                table="Food";
                con.Open();
                SqlDataAdapter da4 = new SqlDataAdapter("select *from Food", con);
                da4.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 5:
                DataList2.DataSource = "";
                DataList2.DataBind();
                table="hotels";
                con.Open();
                SqlDataAdapter da5 = new SqlDataAdapter("select *from hotels", con);
                da5.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 6:
                DataList2.DataSource = "";
                DataList2.DataBind();
                table="hospital";
                con.Open();
                SqlDataAdapter da6 = new SqlDataAdapter("select *from hospital", con);
                da6.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 7:
                DataList2.DataSource = "";
                DataList2.DataBind();
                table="pharmacy";
                con.Open();
                SqlDataAdapter da7 = new SqlDataAdapter("select *from pharmacy", con);
                da7.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 8:
                DataList2.DataSource = "";
                DataList2.DataBind();
                table="shopping";
                con.Open();
                SqlDataAdapter da8 = new SqlDataAdapter("select *from Shopping", con);
                da8.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 9:
                DataList2.DataSource = "";
                DataList2.DataBind();
                table="train";
                con.Open();
                SqlDataAdapter da9 = new SqlDataAdapter("select *from train", con);
                da9.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
            case 10:
                DataList2.DataSource = "";
                DataList2.DataBind();
                table="taxi";
                con.Open();
                SqlDataAdapter da10 = new SqlDataAdapter("select *from taxi", con);
                da10.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
                break;
        }
    }
    
    protected void name_click(object sender, EventArgs e)
    {
        LinkButton BuyNowButton = (LinkButton)sender;
        DataListItem item = (DataListItem)BuyNowButton.NamingContainer;
        LinkButton name = (LinkButton)item.FindControl("name");
        ClientScript.RegisterStartupScript(this.GetType(), "hwa", "f1();", true);
        con.Open();
        SqlCommand cmd = new SqlCommand("delete from " + table + " where name='" +name.Text+ "'", con);
        cmd.ExecuteNonQuery();
        con.Close();
        
       
        
    }
    
}