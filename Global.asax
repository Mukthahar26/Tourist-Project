<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        Application["visitor"] = 0;
        Application["n"] =(int) 0;

    }

    void Application_End(object sender, EventArgs e)
    {

    }

    void Application_Error(object sender, EventArgs e)
    {

    }

    void Session_Start(object sender, EventArgs e)
    {
        Application["visitor"] =(int)Application["visitor"] + 1;
        Application.Lock();
        Application["n"] = (int)Application["n"] + 1;
        Application.UnLock();
    }

    void Session_End(object sender, EventArgs e)
    {
        Application.Lock();
        Application["n"] = (int)Application["n"] - 1;
        Application.UnLock();
    }
       
</script>
