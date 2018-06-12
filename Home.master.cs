using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.SqlClient;

public partial class Home : System.Web.UI.MasterPage
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dropdown();
        }
        
        if (Session["user"] != null)
        {
            chat.Visible = true;
            noprofile.Visible = false;
            profilename1.Visible = true;
            profilename.InnerText = Session["user"].ToString();
            profile1.Visible = true;
            logi1.Visible = false;
            logout1.Visible = true;
        }
        else
        {
            chat.Visible = false;
            noprofile.Visible=true;
            profilename1.Visible = false;
            profile1.Visible = false;
            logout1.Visible = false;
        }
    }
    protected void logout_click(object sender, EventArgs e)
    {
        Session["user"] =null;
        profile1.Visible = false;
        logout1.Visible = false;
        logi1.Visible = true;
        Server.Transfer("Start.aspx");
    }
    

    /*===============================================Search Box====================================================*/

    private void dropdown()
    {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select subcategory from Category order by subcategory asc", con);
        da.Fill(ds);
        DropDownList1.DataSource = ds;
        DropDownList1.DataTextField = "subcategory";
        DropDownList1.DataBind();
        con.Close();
    }
    protected void bsearch_Click(object sender, EventArgs e)
    {
        switch (DropDownList1.SelectedIndex)
        {
            case 1:
                Session["page"] = tsearch.Text;
                Response.Redirect("ATMview.aspx");
                break;
            case 2:
                Session["page"] = tsearch.Text;
                Response.Redirect("banksview.aspx");
                break;
            case 3:
                Session["page"] = tsearch.Text;
                Response.Redirect("bakerysviews.aspx");
                break;
            case 4:
                Session["page"] = tsearch.Text;
                Response.Redirect("busview.aspx");
                break;
            case 5:
                Session["page"] = tsearch.Text;
                Response.Redirect("Cuisineview.aspx");
                break;
            case 6:
                Session["page"] = tsearch.Text;
                Response.Redirect("fastfoodview.aspx");
                break;
            case 7:
                Session["page"] = tsearch.Text;
                Response.Redirect("financeview.aspx");
                break;
            case 8:
                Session["page"] = tsearch.Text;
                Response.Redirect("touristview.aspx");
                break;
            case 9:
                Session["page"] = tsearch.Text;
                Response.Redirect("HospitalView.aspx");
                break;
            case 10:
                Session["page"] = tsearch.Text;
                Response.Redirect("hotelview.aspx");
                break;
            case 11:
                Session["page"] = tsearch.Text;
                Response.Redirect("Companyiew.aspx");
                break;
            case 12:
                Session["page"] = tsearch.Text;
                Response.Redirect("marketingview.aspx");
                break;
            case 13:
                Session["page"] = tsearch.Text;
                Response.Redirect("Mart.aspx");
                break;
            case 14:
                Session["page"] = tsearch.Text;
                Response.Redirect("parkview.aspx");
                break;
            case 15:
                Session["page"] = tsearch.Text;
                Response.Redirect("Pharmacyview.aspx");
                break;
            case 16:
                Session["page"] = tsearch.Text;
                Response.Redirect("shoppingview.aspx");
                break;
            case 17:
                Session["page"] = tsearch.Text;
                Response.Redirect("trainview.aspx");
                break;
        }
    }
}
