using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Web.UI.HtmlControls;

public partial class feedbackview : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select *from feedback", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataList1.DataSource = ds;
        DataList1.DataBind();
        con.Close();
        }

        foreach (DataListItem item in DataList1.Items)
        {
            LinkButton replay = (LinkButton)item.FindControl("replay");
            LinkButton replay1 = (LinkButton)item.FindControl("replay1");
            Button breplay = (Button)item.FindControl("breplay");
            AsyncPostBackTrigger trigger = new AsyncPostBackTrigger();
            trigger.ControlID = "replay";
            trigger.ControlID = "replay1";
            trigger.ControlID = "breplay";
        }
    }
    protected void replay_click(object sender, EventArgs e)
    {
        LinkButton BuyNowButton = (LinkButton)sender;
        DataListItem item = (DataListItem)BuyNowButton.NamingContainer;
        HtmlGenericControl div = (HtmlGenericControl)item.FindControl("div");
        LinkButton replay = (LinkButton)item.FindControl("replay");
        LinkButton replay1 = (LinkButton)item.FindControl("replay1");

        div.Attributes.CssStyle.Add("display", "block");

        replay.Visible = false;
        replay1.Visible = true;
    }

    protected void replay1_click(object sender, EventArgs e)
    {
        LinkButton BuyNowButton = (LinkButton)sender;
        DataListItem item = (DataListItem)BuyNowButton.NamingContainer;
        HtmlGenericControl div = (HtmlGenericControl)item.FindControl("div");
        LinkButton replay = (LinkButton)item.FindControl("replay");
        LinkButton replay1 = (LinkButton)item.FindControl("replay1");

        div.Attributes.CssStyle.Add("display", "none");

        replay.Visible = true;
        replay1.Visible = false;
    }


    protected void breplay_click(object sender, EventArgs e)
    {
        Button BuyNowButton = (Button)sender;
        DataListItem item = (DataListItem)BuyNowButton.NamingContainer;
        TextBox treplay = (TextBox)item.FindControl("treplay");
        Label success = (Label)item.FindControl("success");
        Label success1 = (Label)item.FindControl("Label1");

        MailMessage mm = new MailMessage();
        mm.To.Add(success1.Text);
        mm.From = new MailAddress("citysmart269@gmail.com");
        mm.Subject = "Smart City:Feedback Replay";
        mm.Body = treplay.Text;
        mm.IsBodyHtml = false;
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.EnableSsl = true;
        NetworkCredential NetworkCred = new NetworkCredential("citysmart269@gmail.com", "8688028066");
        smtp.UseDefaultCredentials = true;
        smtp.Credentials = NetworkCred;
        smtp.Port = 587;
        smtp.Send(mm);

        success.Text = "Successfully sent";
    }
}