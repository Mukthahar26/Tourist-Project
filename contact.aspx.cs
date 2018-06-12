using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using System.Net;
using System.Net;
using System.Net.Mail;
using System.Collections.Specialized;

public partial class contact : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    protected void Page_Load(object sender, EventArgs e)
    {  
        HtmlGenericControl search = (HtmlGenericControl)Master.FindControl("search");
        search.Visible = false;
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        
        try
        {
            MailMessage mm = new MailMessage();
            mm.To.Add(email.Text);
            mm.From = new MailAddress("citysmart269@gmail.com");
            mm.Subject = "Thank you for your Feedback";
            mm.Body = "Thank you for your Feedback. We will respond very shortly";
            mm.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            NetworkCredential NetworkCred = new NetworkCredential("citysmart269@gmail.com", "8688028066");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            smtp.Send(mm);
      
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into feedback values('" + name.Text + "','" + email.Text + "','" + message.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            label.Text = "Your Feedback send Successfully. Shortly we will response you......";
            
        }

        catch (Exception ex)
        {
            label.Text = "Incorrect Email ID";
        }  
    }
}