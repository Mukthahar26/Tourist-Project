<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="regsheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
<div id="reg" >
<h2>Registration</h2>
    <form id="f1" runat="server">
    <p>First Name</p>
    <asp:TextBox ID="first" runat="server" placeholder="First Name" class="t"></asp:TextBox>
    <p>Last Name</p>
    <asp:TextBox ID="last" placeholder="Last Name" runat="server" class="t"></asp:TextBox>
    <p>User Name</p>
    <asp:TextBox ID="username" placeholder="User Name" runat="server" class="t"></asp:TextBox>
    <p>E-Mail</p>
    <asp:TextBox ID="mail" placeholder="E-Mail" runat="server" class="t" ></asp:TextBox>
    <p>Phone Number</p>
    <asp:TextBox ID="phno" placeholder="Phone Number" runat="server" class="t" ></asp:TextBox>
    <p>Password</p>
    <asp:TextBox ID="password" placeholder="Password" runat="server" class="t" TextMode="Password" ></asp:TextBox>
    <p>Confirm Password</p>
    <asp:TextBox ID="confirmpassword" placeholder="Confirm Password" runat="server" class="t" TextMode="Password"></asp:TextBox>
    <asp:Button Text="Registration" ID="Button1" runat="server" Class="b" onclick="Button1_Click"/>
        
   <center class="center"><asp:Label ID="Label1" runat="server" Text="" ></asp:Label></center>
    
    </form></div>
</body>
</html>
