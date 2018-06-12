using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Health : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    string image;
    protected void Page_Load(object sender, EventArgs e)
    { 
        if (!IsPostBack)
        {
            f2();
        }
        if (services.SelectedItem + "" == "Pharmacy")
        {
            de.Visible = false;
        }
        else
        de.Visible = true;
    }

    private void f2()
    {
        
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select subcategory from Category where category='" + "Health" + "' order by subcategory asc", con);
            services.DataSource = cmd2.ExecuteReader();
            services.DataTextField = "subcategory";
            services.DataBind();
            con.Close();
        }

    protected void submit_Click(object sender, EventArgs e)
    {
        if ((name.Text != "") && (mail.Text != "") && (contact.Text != "") && (street.Text != "") && (address.Text != ""))
        {
            if (fileup.HasFile)
            {
                if (fileup.PostedFile.ContentType == "image/jpeg")
                {
                    String img = Class1.GetRandomPassword();
                    fileup.PostedFile.SaveAs(Server.MapPath("~/health/" + img + fileup.FileName));
                    image = "~/health/" + img + fileup.FileName;
                    if (services.SelectedItem + "" == "Hospital")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into hospital values(" + img + ",'" + "Health" + "','" + services.SelectedItem + "" + "','" + name.Text + "','" + image + "','" + mail.Text + "','" + contact.Text + "','" + street.Text + "','" + address.Text + "','" + desc.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into pharmacy values(" + img + ",'" + "Health" + "','" + services.SelectedItem + "" + "','" + name.Text + "','" + image + "','" + mail.Text + "','" + contact.Text + "','" + street.Text + "','" + address.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    label.Text = "Success";
                }
                else
                    label.Text = "Please upload Image file";
            }
            else
                label.Text = "Please Select File";
        }
        else
            label.Text = "Please fill all Fields";
        
    }
}