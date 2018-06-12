using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class tourism : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    String s, image;
    int count;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           f3();
        }
    }
   
    private void f3()
    {
        con.Open();
        SqlCommand cmd2 = new SqlCommand("select subcategory from Category where category='" + "Tourism" + "' order by subcategory asc", con);
        subcateg.DataSource = cmd2.ExecuteReader();
        subcateg.DataTextField = "subcategory";
        subcateg.Items.Clear();
        subcateg.DataBind();
        con.Close();
    }


    protected void publish_Click(object sender, EventArgs e)
    {
        if ((tittle.Text != "") && (desc.Text != ""))
        {
            count = Convert.ToInt32(Class1.GetRandomPassword());
            if (fileup1.HasFile)
            {
                if (fileup1.PostedFile.ContentType == "image/jpeg")
                {
                    String img = Class1.GetRandomPassword();
                    fileup1.PostedFile.SaveAs(Server.MapPath("~/Tourist/" + img + fileup1.FileName));
                    image = "~/Tourist/" + img + fileup1.FileName;
                    con.Open();
                    s = desc.Text;
                    SqlCommand cmd4 = new SqlCommand("insert into tourism values(" + count + ",'" + "Tourism" + "','" + subcateg.SelectedItem + "" + "','" + tittle.Text + "','" + image + "','" + s + "')", con);
                    cmd4.ExecuteNonQuery();
                    con.Close();
                    label2.Text = "Success";
                }
                else
                    Label1.Text = "Please select JPG/JPEG extension file";
            }
            else
                Label1.Text = "No Picture selected";
        }
        else
        {
            label2.Text="Please fill all Fields";
        }
    }
    
}