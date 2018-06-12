using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class hotels : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    String img, image;
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    
   
    protected void publish_Click(object sender, EventArgs e)
    {
        if ((tittle.Text != "") && (price.Text != "") && (desc.Text != "")&&(contact.Text!=""))
        {
            if (fileup1.HasFile)
            {
                if (fileup1.PostedFile.ContentType == "image/jpeg")
                {
                    img = Class1.GetRandomPassword();
                    fileup1.PostedFile.SaveAs(Server.MapPath("~/hotel/" + img + fileup1.FileName));
                    image = "~/hotel/" + img + fileup1.FileName;
                    con.Open();
                    SqlCommand cmd4 = new SqlCommand("insert into hotels values(" + img + ",'" + RadioButtonList1.SelectedItem + "','" + RadioButtonList2.SelectedItem + "','" + tittle.Text + "','" + image + "','" +contact.Text+"','"+ price.Text + "','" + desc.Text + "')", con);
                    cmd4.ExecuteNonQuery();
                    con.Close();
                    Label1.Text = "Success";
                }
                else
                    Label1.Text = "Please upload Image file";
            }
            else
                Label1.Text = "File Not found";
        }
        else
            Label1.Text = "Please fill all Fields";
        
    }
    
}