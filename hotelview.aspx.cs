using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class hotelview : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("User ID=sa;password=123;Database=smart city");
    DataSet ds = new DataSet();
    int from=0, to=0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            f1();
            f2();
        }
        if (Session["page"] == null)
        {
            if ((price.SelectedItem + "" == "None") || (type.SelectedItem + "" == "None") || (stars.SelectedItem + "" == "None"))
            {
                if ((price.SelectedItem + "" == "None") || (type.SelectedItem + "" == "None"))
                {
                    if ((price.SelectedItem + "" == "None") || (stars.SelectedItem + "" == "None"))
                    {
                        if ((type.SelectedItem + "" == "None") || (stars.SelectedItem + "" == "None"))
                        {
                            if (type.SelectedItem + "" == "None")
                            {
                                if (stars.SelectedItem + "" == "None")
                                {
                                    if (price.SelectedItem + "" == "None")
                                    {
                                        con.Open();
                                        SqlDataAdapter da = new SqlDataAdapter("select *from hotels", con);
                                        DataSet ds = new DataSet();
                                        da.Fill(ds);
                                        DataList1.DataSource = ds;
                                        DataList1.DataBind();
                                        con.Close();
                                    }
                                    else
                                    {
                                        f3();
                                        con.Open();
                                        SqlDataAdapter da = new SqlDataAdapter("select *from hotels where price between '" + from + "' and '" + to + "'", con);
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
                                    SqlDataAdapter da1 = new SqlDataAdapter("select *from hotels where stars='" + stars.SelectedItem + "" + "'", con);
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
                                SqlDataAdapter da = new SqlDataAdapter("select *from hotels where type='" + type.SelectedItem + "" + "'", con);
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
                            SqlDataAdapter da = new SqlDataAdapter("select *from hotels where type='" + type.SelectedItem + "" + "' and stars='" + stars.SelectedItem + "" + "'", con);
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            DataList1.DataSource = ds;
                            DataList1.DataBind();
                            con.Close();
                        }
                    }
                    else
                    {
                        f3();
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter("select *from hotels where price between '" + from + "' and '" + to + "' and stars='" + stars.SelectedItem + "" + "'", con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        DataList1.DataSource = ds;
                        DataList1.DataBind();
                        con.Close();
                    }
                }
                else
                {
                    f3();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select *from hotels where price between '" + from + "' and '" + to + "' and type='" + type.SelectedItem + "" + "'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataList1.DataSource = ds;
                    DataList1.DataBind();
                    con.Close();
                }
            }
            else
            {
                f3();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select *from hotels where price between '" + from + "' and '" + to + "' and type='" + type.SelectedItem + "" + "' and stars='" + stars.SelectedItem + "" + "'", con);
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
            SqlDataAdapter da = new SqlDataAdapter("select *from hotels where name like '%"+Session["page"]+"%'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
            con.Close();
            Session["page"]=null;
        }
    }
        

    private void f1()
    {
        con.Open();
        SqlDataAdapter da1 = new SqlDataAdapter("select type from hotels group by type", con);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        type.DataSource = ds1;
        type.DataTextField = "type";
        type.DataBind();
        con.Close();
    }
    private void f2()
    {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select stars from hotels group by stars", con);
        DataSet ds1 = new DataSet();
        da.Fill(ds1);
        stars.DataSource = ds1;
        stars.DataTextField = "stars";
        stars.DataBind();
        con.Close();
    }
    private void f3()
    {
        switch (price.SelectedIndex)
        {

            case 1:
                {
                    from = 1000;
                    to = 2000;
                    break;
                }
            case 2:
                {
                    from = 2000;
                    to = 3000;
                    break;
                }
            case 3:
                {
                    from = 3000;
                    to = 4000;
                    break;
                }
            case 4:
                {
                    from = 4000;
                    to = 6000;
                    break;
                }
            case 5:
                {
                    from = 6000;
                    to = 9999;
                    break;
                }
        }
    }
    protected void comment_Click(object sender, EventArgs e)
    {
        LinkButton BuyNowButton = (LinkButton)sender;
        DataListItem item = (DataListItem)BuyNowButton.NamingContainer;
        Label lb = (Label)item.FindControl("Label1");
        Label NameLabel = (Label)item.FindControl("name");
        Session["name"] = NameLabel.Text;
        Server.Transfer("comment.aspx");
    }
    protected void DataList1_Load(object sender, EventArgs e)
    {
        if (DataList1.Items.Count < 1)
        {
            border.Visible = true;
        }
        else
        {
            border.Visible = false;
        }
    }
}