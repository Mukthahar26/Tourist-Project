using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class duscussionview : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("user ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from discussion", con);
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
            con.Close();
        }
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into discussion values('" + name.Text + "','" + DateTime.Now+ "','" + comment.Text + "')", con);
        cmd.ExecuteNonQuery();
        con.Close();
        Server.Transfer("duscussionview.aspx");
    }
    
}