using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administration : System.Web.UI.MasterPage
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {

        }   
    }
    protected void home_click(object sender, EventArgs e)
    {
        Response.Redirect("adminhome.aspx");
    }
}
