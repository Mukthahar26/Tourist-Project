using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Net;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Data;

public partial class OTP : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    protected void Page_Load(object sender, EventArgs e)
    {

        success.Visible = false;
        success.Visible = false;
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        if (otp.Text == Session["otp"].ToString())
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into login (id,firstname,lastname,username,email,phone,password,confirmpassword) values(" + Session["id"] + ",'" + Session["first"] + "','" + Session["last"] + "','" + Session["username"] + "','" + Session["mail"] + "','" + Session["phone"] + "','" + Session["password"] + "','" + Session["cpassword"] + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fail.Visible = false;
            success.Text = "Congratulations you are registered successfully, thank you.";
            success.Visible = true;
            Session["aa"] = "on";
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "5;url=Start.aspx";
            this.Page.Controls.Add(meta);
        }
        else
        {
            success.Visible = false;
            fail.Text = "Wrong OTP Entered";
            fail.Visible = true;
        }
    }
    protected void resend_Click(object sender, EventArgs e)
    {
        f1();
    }
    private void f1()
    {
        Session["otp"] = Class1.GetRandomPassword();
        string destinationaddr = "+91" + Session["phone"];
        string message = "Hi Your OTP is: " + Session["otp"].ToString();
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