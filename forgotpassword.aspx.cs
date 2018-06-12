using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class forgotpassword : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlGenericControl search = (HtmlGenericControl)Master.FindControl("search");
        search.Visible = false;
    }
    protected void send_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd1 = new SqlCommand("select count(*) from login where email='"+box.Text+"'", con);
        int i = Convert.ToInt32(cmd1.ExecuteScalar());
        if (i >= 1)
        {
                MailMessage mm = new MailMessage();
                mm.To.Add(box.Text);
                mm.From = new MailAddress("citysmart269@gmail.com");
                mm.Subject = "Recover Password";
                mm.Body = "Please recover your password from <a href=\"http://localhost:4098/smart%20city/passwordrecovery.aspx\">here</a>";
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential("citysmart269@gmail.com", "8688028066");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mm);
                Label1.Attributes.CssStyle.Add("Color", "green");
                Label1.Text = "Password Recovery Link Sent to your Mail";
                Session["email"] = box.Text;
          
        }
        else
        {
            Label1.Text = "This Email Not Registered";
        }
       
    }
}