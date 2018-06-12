using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Editprofile : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    int id = 123;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            con.Open();
            SqlCommand da = new SqlCommand("select *from login where username='" + Session["user"] + "'", con);
            SqlDataReader dr = da.ExecuteReader();
            if (dr.Read())
            {
                fname.Text = dr["firstname"].ToString();
                lname.Text = dr["lastname"].ToString();
                username.Text = dr["username"].ToString();
                email.Text = dr["email"].ToString();
                phone.Text = dr["phone"].ToString();
                pro.Text = dr["professionality"].ToString();
                if (dr["gender"].ToString() == "Male" || dr["gender"].ToString() == "Female")
                {
                    gender.Items.FindByText(dr["gender"].ToString()).Selected = true;
                }
            }
            con.Close();
        }
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        con.Open();
        string cmd = "UPDATE login SET firstname=@fname, lastname=@lname, username=@username, email=@email, phone=@phone, gender=@gender, professionality=@pro where username=@user";
        SqlCommand sql = new SqlCommand(cmd, con);
        sql.Parameters.AddWithValue("@user",Session["user"]);
        sql.Parameters.AddWithValue("@fname", fname.Text);
        sql.Parameters.AddWithValue("@lname", lname.Text);
        sql.Parameters.AddWithValue("@username", username.Text);
        sql.Parameters.AddWithValue("@email", email.Text);
        sql.Parameters.AddWithValue("@phone", phone.Text);
        sql.Parameters.AddWithValue("@gender", gender.SelectedItem + "");
        sql.Parameters.AddWithValue("@pro", pro.Text);
        sql.ExecuteNonQuery();
        con.Close();

        Server.Transfer("Profile.aspx");
    }
    
}