using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class taxiinsert : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    String count, image;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submit_click(object sender, EventArgs e)
    {
        if ((TextBox1.Text != "") && (name.Text != "") && (contact.Text != ""))
        {
            if (fileup.HasFile)
            {
                if (fileup.PostedFile.ContentType == "image/jpeg")
                {
                    count = Class1.GetRandomPassword();
                    fileup.PostedFile.SaveAs(Server.MapPath("~/Taxi/" + count + fileup.FileName));
                    image = "~/Taxi/" + count + fileup.FileName;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into taxi values(" + count + ",'" + TextBox1.Text + "','" + image + "','" + name.Text + "','" + contact.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    l.Text = "Success";
                }
                else
                    l.Text = "Please select image file";
            }
            else
                l.Text = "Please select file";
        }
        else
            l.Text = "Please Fill All Fileds";
    }
}