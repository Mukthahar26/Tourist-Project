using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Net;
using System.Collections.Specialized;

public partial class taxiconfirmation : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    string str;
    protected void Page_Load(object sender, EventArgs e)
    {
        success.Visible = false;
        str = Session["user"].ToString();
        HtmlGenericControl search = (HtmlGenericControl)Master.FindControl("search");
        search.Visible = false;
        if (str != "")
        {
            vehicle.InnerText = Session["taxiname"].ToString();
            owner.InnerText = Session["taxiowner"].ToString();
            name.InnerText = str;
            cont.InnerText = Session["contact"].ToString();
            f1();
        }
    }
    private void f1()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select *from login where username='" + Session["user"] + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            name.InnerText = dr["username"].ToString();
            Contact.InnerText = dr["phone"].ToString();
        }
        con.Close();
    }

    protected void booking_click(object sender, EventArgs e)
    {
        f2();
        success.Visible = true;
        success.Text = "Thank for your booking Request. Vehicle person will call you very soon.";
    }

    private void f2()
    {
        string destinationaddr = "+91" + cont.InnerText;
        string message = "Hi "+owner.InnerText+", your vehicle ("+vehicle.InnerText+") booking, requested by " + str + ". Please contact them on " + Contact.InnerText + " for more information";
        String message1 = HttpUtility.UrlEncode(message);
        using (var wb = new WebClient())
        {
            byte[] response = wb.UploadValues("https://api.textlocal.in/send/", new NameValueCollection()
                {
                  {"apikey" , "V7thr6z5mEI-vKd0T15vq0f3wdSQnkVPNVP7ZqFryV"},
                  {"numbers" , destinationaddr},
                  {"message" , message1},
                  {"sender" , "TXTLCL"}
                });
            string result = System.Text.Encoding.UTF8.GetString(response);
        }
    }
}