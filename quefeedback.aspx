<%@ Page Language="C#" AutoEventWireup="true" CodeFile="quefeedback.aspx.cs" Inherits="quefeedback" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    body
    {
        background:rgba(0,0,0,0.9);
    }
    h1
    {
         color:White;
    }
    .user
    {
        color:White;
        font-family:Arial;
        font-size:18px;
    }
    
    
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <center>
    <h1>FeedBack</h1>
        <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <asp:LinkButton ID="username" runat="server" CssClass="user" Text='<%#Eval("username") %>' OnClick="username_click" style="text-decoration:none"></asp:LinkButton>
        </ItemTemplate>
        </asp:DataList>
    </center>
    </div>
    </form>
</body>
</html>
