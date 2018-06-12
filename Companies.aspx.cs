using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Companies : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    int count;
    string image;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            f2();
        }
    }
    
    private void f2()
    {
        con.Open();
        SqlCommand cmd=new SqlCommand("select subcategory from Category where category='"+"Company"+"'",con);
        DropDownList1.DataSource = cmd.ExecuteReader();
        DropDownList1.DataTextField = "subcategory";
        DropDownList1.DataBind();
        con.Close();
    }
    protected void publish_Click(object sender, EventArgs e)
    {
        if ((tittle.Text != "") && (mail.Text != "") && (contact.Text != "") && (fax.Text != "") && (url.Text != "") && (address.Text != ""))
        {
            if (fileup.HasFile)
            {
                if (fileup.PostedFile.ContentType == "image/jpeg")
                {
                    String img = Class1.GetRandomPassword();
                    fileup.PostedFile.SaveAs(Server.MapPath("~/company/" + img + fileup.FileName));
                    image = "~/company/" + img + fileup.FileName;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into company values(" + img + ",'" + "Company" + "','" + DropDownList1.SelectedItem + "" + "','" + tittle.Text + "','" + image + "','" + contact.Text + "','" + mail.Text + "','" + fax.Text + "','" + url.Text + "','" + address.Text + "','" + desc.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    label1.Text = "Success";
                }
                else
                    label1.Text = "Please select Image file";
            }
            else
                label1.Text = "Please select file";
        }
        else
            label1.Text = "Please fill all Fields";
    }
}