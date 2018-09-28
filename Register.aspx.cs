using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Net;
using System.Collections.Specialized;

public partial class Register : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlGenericControl search = (HtmlGenericControl)Master.FindControl("search");
        search.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if ((first.Text != "") && (last.Text != "") && (username.Text != "") && (mail.Text != "") && (phno.Text != "") && (password.Text != "") && (confirmpassword.Text != ""))
        {
            Label1.Text = "";
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select count(*) from login where username='" + username.Text + "' and password='" + password.Text + "'", con);
            int i = Convert.ToInt32(cmd1.ExecuteScalar());
            if (i >= 1)
            {
                Label1.Text = "This User Name/Mail already exist";
                con.Close();
            }

            else
            {
                if (password.Text == confirmpassword.Text)
                {
                    string s = Class1.GetRandomPassword();
                    Session["id"] = s;
                    Session["first"] = first.Text;
                    Session["last"] = last.Text;
                    Session["username"] = username.Text;
                    Session["mail"] = mail.Text;
                    Session["phone"] = phno.Text;
                    Session["password"] = password.Text;
                    Session["cpassword"] = confirmpassword.Text;
                    Session["otp"] = Class1.GetRandomPassword();

                    //----------------------------------------------------------------
                    try
                    {
                        MailMessage mm = new MailMessage();
                        mm.To.Add(mail.Text);
                        mm.From = new MailAddress("xxxxxx@gmail.com");
                        mm.Subject = "Thank you";
                        mm.Body = "Thank you for your Registration";
                        mm.IsBodyHtml = true;
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        NetworkCredential NetworkCred = new NetworkCredential("E-Mail", "Password");
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = NetworkCred;
                        smtp.Port = 587;
                        smtp.Send(mm);
                        f1();
                        Server.Transfer("OTP.aspx");
                    }

                    catch (Exception ex)
                    {
                        Label1.Text = "Incorrect Email ID";
                    }

                    //----------------------------------------------------------------

                }

                else
                {
                    con.Close();
                    Label1.Text = "Password not matched";
                }

            }
        }
        else
        {
            Label1.Text = "Please Fill all fields";
        }
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
                  {"apikey" , "---------------------------------------"},
                  {"numbers" , destinationaddr},
                  {"message" , message1},
                  {"sender" , "TXTLCL"}
                });
            string result = System.Text.Encoding.UTF8.GetString(response);
        }
    }
    
}
