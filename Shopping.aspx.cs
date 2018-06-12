using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Shopping : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    string img, image;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            f1();
        }
    }
    private void f1()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select subcategory from Category where category='" + "Shopping" + "' order by subcategory", con);
        services.DataSource = cmd.ExecuteReader();
        services.DataTextField = "subcategory";
        services.DataBind();
        con.Close();
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        if ((name.Text != "") && (desc.Text != ""))
        {
            if (fileup.HasFile)
            {
                if (fileup.PostedFile.ContentType == "image/jpeg")
                {
                    img = Class1.GetRandomPassword();
                    fileup.PostedFile.SaveAs(Server.MapPath("~/shopping/" + img + fileup.FileName));
                    image = "~/shopping/" + img + fileup.FileName;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Shopping values(" + img + ",'" + "Shopping" + "','" + services.SelectedItem + "" + "','" + name.Text + "','" + image + "','" + desc.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    label.Text = "Success";
                }
                else
                    label.Text = "Please select jpg Format";
            }
            else
                label.Text = "Please Select Image File";
        }
        else
            label.Text = "Please fill all Fields";
        
    }
}