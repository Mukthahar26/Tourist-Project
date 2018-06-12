using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class updatehotels : System.Web.UI.Page
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
            SqlCommand cmd = new SqlCommand("Select *from hotels where id=" + id + "", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tittle.Text = dr["name"].ToString();
                RadioButtonList1.Items.FindByText(dr["type"].ToString()).Selected = true;
                RadioButtonList2.Items.FindByText(dr["stars"].ToString()).Selected = true;
                Image1.ImageUrl = dr["image"].ToString();
                contact.Text = dr["contact"].ToString();
                price.Text = dr["price"].ToString();
                desc.Text = dr["description"].ToString();
            }
        }
    }
    private void f1()
    {
        con.Open();
        SqlCommand da = new SqlCommand("select id from hotels where name='" + Session["name"] + "'", con);
        SqlDataReader dr = da.ExecuteReader();
        if (dr.Read())
        {
            id = Convert.ToInt32(dr["id"]);
        }
        con.Close();
    }

    protected void submit_click(object sender, EventArgs e)
    {
        if (fileup1.HasFile)
        {
            if (fileup1.PostedFile.ContentType == "image/jpeg")
            {
                String img = Class1.GetRandomPassword();
                fileup1.PostedFile.SaveAs(Server.MapPath("~/Tourist/" + img + fileup1.FileName));
                string image = "~/Tourist/" + img + fileup1.FileName;
                con.Open();
                SqlCommand cmd4 = new SqlCommand("update hotels set type='" + RadioButtonList1.SelectedItem + "" + "',stars='" + RadioButtonList2.SelectedItem + "" + "',image='" + image + "',contact='" + contact.Text + "',price='" + price.Text + "',description='" + desc.Text + "' where id=" + id + "", con);
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
            SqlCommand cmd4 = new SqlCommand("update hotels set type='" + RadioButtonList1.SelectedItem + "" + "',stars='" + RadioButtonList2.SelectedItem + "" + "',contact='" + contact.Text + "',price='" + price.Text + "',description='" + desc.Text + "' where id="+id+"", con);
            cmd4.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Success";
        }
    }
}