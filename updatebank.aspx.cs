using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class updatebank : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    int id, count;
    string image, s;
    protected void Page_Load(object sender, EventArgs e)
    {
        f1();
        if (!IsPostBack)
        {
            f2();
            f3();
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from banks where id=" + id + "", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                services.Items.FindByText(dr["subcategory"].ToString()).Selected = true;
                names.Items.FindByText(dr["name"].ToString()).Selected = true;
                street.Text = dr["street"].ToString();
                address.Text = dr["address"].ToString();
                Image1.ImageUrl = dr["image"].ToString();
            }
            con.Close();
        }
    }


    protected void submit_Click(object sender, EventArgs e)
    {
        if ((street.Text != "") && (address.Text != ""))
        {
            if (fileup.HasFile)
            {
                if (fileup.PostedFile.ContentType == "image/jpeg")
                {
                    String img = Class1.GetRandomPassword();
                    fileup.PostedFile.SaveAs(Server.MapPath("~/Tourist/" + img + fileup.FileName));
                    image = "~/Tourist/" + img + fileup.FileName;
                    con.Open();
                    SqlCommand cmd4 = new SqlCommand("update banks set subcategory='" + services.SelectedItem + "" + "',name='" + names.SelectedItem + "" + "', image='" + image + "',address='" + address.Text + "' where id=" + id + "", con);
                    cmd4.ExecuteNonQuery();
                    con.Close();
                    l.Text = "Success";
                }
                else
                {
                    l.Text = "Please select JPG/JPEG extension file";
                }
            }
            else
            {
                String img = Class1.GetRandomPassword();
                fileup.PostedFile.SaveAs(Server.MapPath("~/Tourist/" + img + fileup.FileName));
                image = "~/Tourist/" + img + fileup.FileName;
                con.Open();
                SqlCommand cmd4 = new SqlCommand("update banks set subcategory='" + services.SelectedItem + "" + "',name='" + names.SelectedItem + "" + "',address='" + address.Text + "' where id=" + id + "", con);
                cmd4.ExecuteNonQuery();
                con.Close();
                l.Text = "Success";
            }
        }
        else
        {
            l.Text = "Please fill all Fields";
        }
    }

    private void f1()
    {
        con.Open();
        SqlCommand da = new SqlCommand("select id from banks where name='" + Session["name"] + "'", con);
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
        SqlCommand cmd = new SqlCommand("select subcategory from Category where category='" + "Banks" + "' order by subcategory", con);
        services.DataSource = cmd.ExecuteReader();
        services.DataTextField = "subcategory";
        services.DataBind();
        con.Close();
    }
    private void f3()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select bankname from catebank order by bankname", con);
        names.DataSource = cmd.ExecuteReader();
        names.DataTextField = "bankname";
        names.DataBind();
        con.Close();
    }
    private void f4()
    {
        
    }
}