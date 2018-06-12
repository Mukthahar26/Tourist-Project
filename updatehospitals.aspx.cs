using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class updatehospitals : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    int id;
    string image;
    protected void Page_Load(object sender, EventArgs e)
    {
        f1();
        if (!IsPostBack)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from hospital where id=" + id + "", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                name.Text = dr["name"].ToString();
                Image1.ImageUrl = dr["image"].ToString();
                mail.Text = dr["email"].ToString();
                contact.Text = dr["contact"].ToString();
                address.Text = dr["address"].ToString();
                street.Text = dr["street"].ToString();
                desc.Text = dr["description"].ToString();
            }
            con.Close();
        }
    }
    protected void submit_click(object sender, EventArgs e)
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
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update hospital set name='" + name.Text + "',email='" + mail.Text + "',image='" + image + "',contact='" + contact.Text + "',street='" + street.Text + "',address='" + address.Text + "',description='"+desc.Text+"' where id=" + id + "", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    label.Text = "Success";
                }
                else
                    label.Text = "Please upload Image file";
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update hospital set name='" + name.Text + "',email='" + mail.Text + "',contact='" + contact.Text + "',street='" + street.Text + "',address='" + address.Text + "', description='" + desc.Text + "' where id=" + id + "", con);
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
        SqlCommand da = new SqlCommand("select id from hospital where name='" + Session["name"] + "'", con);
        SqlDataReader dr = da.ExecuteReader();
        if (dr.Read())
        {
            id = Convert.ToInt32(dr["id"]);
        }
        con.Close();
    }
}