using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class ATMview : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            f1();
            f2();
        }

        if (Session["page"] == null)
        {
            if ((filter.SelectedItem + "" == "None") || (bank.SelectedItem + "" == "None"))
            {
                if (filter.SelectedItem + "" == "None")
                {
                    if (bank.SelectedItem + "" == "None")
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter("select *from banks where subcategory='" + "ATM" + "'", con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        DataList1.DataSource = ds;
                        DataList1.DataBind();
                        con.Close();
                    }
                    else
                    {
                        con.Open();
                        SqlDataAdapter da1 = new SqlDataAdapter("select *from banks where name='" + bank.SelectedItem + "" + "'and subcategory='" + "ATM" + "'", con);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds);
                        DataList1.DataSource = ds;
                        DataList1.DataBind();
                        con.Close();
                    }
                }
                else
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select *from banks where street='" + filter.SelectedItem + "" + "' and subcategory='" + "ATM" + "'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataList1.DataSource = ds;
                    DataList1.DataBind();
                    con.Close();
                }
            }
            else
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select *from banks where street='" + filter.SelectedItem + "" + "' and name='" + bank.SelectedItem + "" + "' and subcategory='" + "ATM" + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
                con.Close();
            }
        }
        else
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from banks where name like '%"+Session["page"]+"%'and subcategory='" + "ATM" + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
            con.Close();
            Session["page"] = null;
        }
    }
    

    private void f1()
    {
        con.Open();
        SqlDataAdapter da1 = new SqlDataAdapter("select street from banks where subcategory='" + "ATM" + "' group by street", con);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        filter.DataSource = ds1;
        filter.DataTextField = "street";
        filter.DataBind();
        con.Close();
    }
    private void f2()
    {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select name from banks where subcategory='" + "ATM" + "'group by name", con);
        DataSet ds1 = new DataSet();
        da.Fill(ds1);
        bank.DataSource = ds1;
        bank.DataTextField = "name";
        bank.DataBind();
        con.Close();
    }

    protected void DataList1_Load(object sender, EventArgs e)
    {
        if (DataList1.Items.Count <= 0)
        {
            border.Visible = true;
        }
        else
        {
            border.Visible = false;
        }
        
    }
}