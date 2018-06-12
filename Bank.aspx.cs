using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Bank : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    String count,image;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            f1();
            f2();
        }
    }
    private void f1()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select subcategory from Category where category='" + "Banks" + "' order by subcategory", con);
        services.DataSource = cmd.ExecuteReader();
        services.DataTextField = "subcategory";
        services.DataBind();
        con.Close();
    }
    private void f2()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select bankname from catebank order by bankname", con);
        names.DataSource = cmd.ExecuteReader();
        names.DataTextField = "bankname";
        names.DataBind();
        con.Close();
    }
    
    protected void submit_Click(object sender, EventArgs e)
    {
        if ((street.Text != "") && (address.Text != ""))
        {
            if (fileup.HasFile)
            {
                if (fileup.PostedFile.ContentType == "image/jpeg")
                {
                    count = Class1.GetRandomPassword();
                    fileup.PostedFile.SaveAs(Server.MapPath("~/bank/" + count + fileup.FileName));
                    image = "~/bank/" + count + fileup.FileName;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into banks values(" + count + ",'" + "Banks" + "','" + services.SelectedItem + "" + "','" + names.SelectedItem + "" + "','" + image + "','" + street.Text + "','" + address.Text + "')", con);
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
            l.Text = "Please fill all Fields";
    }
}