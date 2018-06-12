using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class taxiupdate : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    String count, image;
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        f1();
        con.Open();
        SqlCommand cmd = new SqlCommand("select *from taxi where id=" + id + "", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            TextBox1.Text = dr["name"].ToString();
            name.Text = dr["owner"].ToString();
            contact.Text = dr["contact"].ToString();
            Image1.ImageUrl = dr["image"].ToString();
        }
        con.Close();
    }

    protected void submit_click(object sender, EventArgs e)
    {
        if (fileup.HasFile)
        {
            if (fileup.PostedFile.ContentType == "image/jpeg")
            {
                fileup.PostedFile.SaveAs(Server.MapPath("~/Taxi/" + count + fileup.FileName));
                image = "~/Taxi/" + count + fileup.FileName;
                con.Open();
                SqlCommand cmd = new SqlCommand("update taxi set name='" + TextBox1.Text + "', image='" + image + "', owner='" + name.Text + "', contact='" + contact.Text + "' where id="+id+"", con);
                cmd.ExecuteNonQuery();
                con.Close();
                l.Text = "Updated";
            }
            else
                l.Text = "Please select image file";
        }
        else
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update taxi set name='" + TextBox1.Text + "', owner='" + name.Text + "', contact='" + contact.Text + "' where id=" + id + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
            l.Text = "Updated";
        }
    }
    private void f1()
    {
        con.Open();
        SqlCommand da = new SqlCommand("select id from taxi where name='" + Session["name"] + "'", con);
        SqlDataReader dr = da.ExecuteReader();
        if (dr.Read())
        {
            id = Convert.ToInt32(dr["id"]);
        }
        con.Close();
    }
}