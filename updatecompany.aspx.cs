using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class updatecompany : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        f2();
        f1();
        if (!IsPostBack)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from company where id=" + id + "", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                DropDownList1.Items.FindByText(dr["subcategory"]+"").Selected = true;
                tittle.Text = dr["name"].ToString();
                Image1.ImageUrl = dr["image"].ToString();
                mail.Text = dr["email"].ToString();
                contact.Text = dr["contact"].ToString();
                fax.Text = dr["fax"].ToString();
                url.Text = dr["url"].ToString();
                address.Text = dr["address"].ToString();
                desc.Text = dr["description"].ToString();
            }
            con.Close();
        }
    }
    private void f1()
    {
        con.Open();
        SqlCommand da = new SqlCommand("select id from company where name='" + Session["name"] + "'", con);
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
        SqlCommand cmd = new SqlCommand("select subcategory from Category where category='" + "Company" + "'", con);
        DropDownList1.DataSource = cmd.ExecuteReader();
        DropDownList1.DataTextField = "subcategory";
        DropDownList1.DataBind();
        con.Close();
    }

    protected void submit_click(object sender, EventArgs e)
    {
        if ((tittle.Text != "") && (mail.Text != "") && (contact.Text != "") && (fax.Text != "") && (url.Text != "") && (address.Text != ""))
        {
            if (fileup.HasFile)
            {
                if (fileup.PostedFile.ContentType == "image/jpeg")
                {
                    String img = Class1.GetRandomPassword();
                    fileup.PostedFile.SaveAs(Server.MapPath("~/Tourist/" + img + fileup.FileName));
                    string image = "~/Tourist/" + img + fileup.FileName;
                    con.Open();
                    SqlCommand cmd4 = new SqlCommand("update company set subcategory='" + DropDownList1.SelectedItem + "" + "', name='" + tittle.Text + "',image='" + image + "',email='" + mail.Text + "',contact='" + contact.Text + "',fax='" + fax.Text + "',url='" + url.Text + "',address='" + address.Text + "',description='" + desc.Text + "' where id=" + id + "", con);
                    cmd4.ExecuteNonQuery();
                    con.Close();
                    label1.Text = "Success";
                }
                else
                    label1.Text = "Please select JPG/JPEG extension file";
            }
            else
            {
                con.Open();
                SqlCommand cmd4 = new SqlCommand("update company set subcategory='" + DropDownList1.SelectedItem + "" + "', name='" + tittle.Text + "',email='" + mail.Text + "',contact='" + contact.Text + "',fax='" + fax.Text + "',url='" + url.Text + "',address='" + address.Text + "',description='" + desc.Text + "' where id=" + id + "", con);
                cmd4.ExecuteNonQuery();
                con.Close();
                label1.Text = "Success";
            }
        }
        else
            label1.Text = "Please Fill All fields";

    }
}