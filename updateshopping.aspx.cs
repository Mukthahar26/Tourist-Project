using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class updateshopping : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    int id;
    string img,image;
    protected void Page_Load(object sender, EventArgs e)
    {
        f1();
        f2();
        if (!IsPostBack)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from Shopping where id=" + id + "", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                services.Items.FindByText(dr["subcategory"].ToString()).Selected = true;
                name.Text = dr["name"].ToString();
                Image1.ImageUrl = dr["image"].ToString();
                desc.Text = dr["description"].ToString();
            }
            con.Close();
        }
    }
    protected void submit_click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("update Shopping set name='" + name.Text + "',image='" + image + "',description='" + desc.Text + "' where id=" + id + "", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    label.Text = "Success";
                }
                else
                    label.Text = "Please select jpg Format";
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Shopping set name='" + name.Text + "',image='" + image + "',description='" + desc.Text + "' where id=" + id + "", con);
                cmd.ExecuteNonQuery();
                con.Close();
                label.Text = "Success";
            }
        }
        else
            label.Text = "Please fill all Fields";
    }
    private void f1()
    {
        con.Open();
        SqlCommand da = new SqlCommand("select id from Shopping where name='" + Session["name"] + "'", con);
        SqlDataReader dr = da.ExecuteReader();
        if (dr.Read())
        {
            id = Convert.ToInt32(dr["id"]);
        }
        con.Close();
    }
    private void f2()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select subcategory from Category where category='" + "Shopping" + "' order by subcategory", con);
        services.DataSource = cmd.ExecuteReader();
        services.DataTextField = "subcategory";
        services.DataBind();
        con.Close();
    }
}