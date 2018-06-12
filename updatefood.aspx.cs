using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class updatefood : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        f1();
        if (!IsPostBack)
        {
            con.Open();
            SqlCommand da = new SqlCommand("select *from Food where id=" + id + "", con);
            SqlDataReader dr = da.ExecuteReader();
            if (dr.Read())
            {
                services.Items.FindByText(dr["subcategory"].ToString()).Selected = true;
                name.Text = dr["name"].ToString();
                Image1.ImageUrl = dr["image"].ToString();
                contact.Text = dr["contact"].ToString();
                street.Text = dr["street"].ToString();
                time.Text = dr["timings"].ToString();
                address.Text = dr["address"].ToString();
            }
        }
    }
    private void f1()
    {
        con.Open();
        SqlCommand da = new SqlCommand("select id from Food where name='" + Session["name"] + "'", con);
        SqlDataReader dr = da.ExecuteReader();
        if (dr.Read())
        {
            id = Convert.ToInt32(dr["id"]);
        }
        con.Close();
    }

    protected void submit_click(object sender, EventArgs e)
    {
        if (fileup.HasFile)
        {
            if (fileup.PostedFile.ContentType == "image/jpeg")
            {
                String img = Class1.GetRandomPassword();
                fileup.PostedFile.SaveAs(Server.MapPath("~/Tourist/" + img + fileup.FileName));
                string image = "~/Tourist/" + img + fileup.FileName;
                con.Open();
                SqlCommand cmd4 = new SqlCommand("update Food set subcategory='" + services.SelectedItem + "" + "', name='" + name.Text + "',image='" + image + "',contact='" + contact.Text + "',street='" + street.Text + "',timings='" + time.Text + "',address='" + address.Text + "' where id=" + id + "", con);
                cmd4.ExecuteNonQuery();
                con.Close();
                Label1.Text = "Success";
            }
            else
                Label1.Text = "Please select JPG/JPEG extension file";
        }
        else
        {
            con.Open();
            SqlCommand cmd4 = new SqlCommand("update Food set subcategory='" + services.SelectedItem + "" + "', name='" + name.Text + "',contact='" + contact.Text + "',street='" + street.Text + "',timings='" + time.Text + "',address='" + address.Text + "' where id=" + id + "", con);
            cmd4.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Success";
        }
    }
}