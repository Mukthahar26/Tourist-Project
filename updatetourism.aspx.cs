using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class updatetourism : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    int id,count;
    string image,s;
    protected void Page_Load(object sender, EventArgs e)
    {
        f1();
        if (!IsPostBack)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from tourism where id=" + id + "", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                subcateg.Items.FindByText(dr["subcategory"].ToString()).Selected = true;
                tittle.Text = dr["name"].ToString();
                desc.Text = dr["description"].ToString();
                Image1.ImageUrl = dr["image"].ToString();
            }
            con.Close();
        }
    }


    private void f1()
    {
        con.Open();
        SqlCommand da = new SqlCommand("select id from tourism where name='" + Session["name"] + "'", con);
        SqlDataReader dr = da.ExecuteReader();
        if (dr.Read())
        {
            id = Convert.ToInt32(dr["id"]);
        }
        con.Close();
    }


    protected void publish_click(object sender, EventArgs e)
    {
        if ((tittle.Text != "") && (desc.Text != ""))
        {
            if (fileup1.HasFile)
            {
                if (fileup1.PostedFile.ContentType == "image/jpeg")
                {
                    String img = Class1.GetRandomPassword();
                    fileup1.PostedFile.SaveAs(Server.MapPath("~/Tourist/" + img + fileup1.FileName));
                    image = "~/Tourist/" + img + fileup1.FileName;
                    con.Open();
                    s = desc.Text;
                    SqlCommand cmd4 = new SqlCommand("update tourism set subcategory='" + subcateg.SelectedItem + "" + "', name='" + tittle.Text + "',image='" + image + "',description='" + desc.Text + "' where id=" + id + "", con);
                    cmd4.ExecuteNonQuery();
                    con.Close();
                    label2.Text = "Success";
                }
                else
                    label2.Text = "Please select JPG/JPEG extension file";
            }
            else
            {
                con.Open();
                SqlCommand cmd4 = new SqlCommand("update tourism set subcategory='" + subcateg.SelectedItem + "" + "', name='" + tittle.Text + "',description='" + desc.Text + "' where id=" + id + "", con);
                cmd4.ExecuteNonQuery();
                con.Close();
                label2.Text = "Success";
            }
        }
        else
        {
            label2.Text="Please fill all Fields";
        }
    }
}