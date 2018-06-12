using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Food : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    string img ,image;
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
        SqlCommand cmd = new SqlCommand("select subcategory from category where category='" + "Food" + "'", con);
        services.DataSource = cmd.ExecuteReader();
        services.DataTextField = "subcategory";
        services.DataBind();
        con.Close();
    }
    
    protected void submit_Click(object sender, EventArgs e)
    {
        if ((name.Text != "") && (contact.Text != "") && (street.Text != "") && (time.Text != "") && (address.Text != ""))
        {
            if (fileup.HasFile)
            {
                if (fileup.PostedFile.ContentType == "image/jpeg")
                {
                    img = Class1.GetRandomPassword();
                    fileup.PostedFile.SaveAs(Server.MapPath("~/food/" + img + fileup.FileName));
                    image = "~/food/" + img + fileup.FileName;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Food values(" + img + ",'" + "Food" + "','" + services.SelectedItem + "" + "','" + name.Text + "','" + image + "','" + contact.Text + "','" + street.Text + "','" + time.Text + "','" + address.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Label1.Text = "Success";
                }
                else
                    Label1.Text = "Please Upload Image file";
            }
            else
            {
                Label1.Text = "Please upload the file";
            }
        }
        else
            Label1.Text = "Please fill all Fields";
        
    }
}