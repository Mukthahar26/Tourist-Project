<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="regsheet.css" rel="stylesheet" type="text/css" />
    
    <div id="reg" >
<h2>Registration</h2>
    <p>First Name</p>
    <asp:TextBox ID="first" runat="server" placeholder="First Name" AutoComplete="off" class="t"></asp:TextBox>
    <p>Last Name</p>
    <asp:TextBox ID="last" placeholder="Last Name" runat="server" AutoComplete="off" class="t"></asp:TextBox>
    <p>User Name</p>
    <asp:TextBox ID="username" placeholder="User Name" runat="server" AutoComplete="off" class="t"></asp:TextBox>
    <p>E-Mail</p>
    <asp:TextBox ID="mail" placeholder="E-Mail" runat="server" AutoComplete="off" class="t" ></asp:TextBox>
    <p>Phone Number</p>
    <asp:TextBox ID="phno" placeholder="Phone Number" runat="server" AutoComplete="off" class="t" ></asp:TextBox>
    <p>Password</p>
    <asp:TextBox ID="password" placeholder="Password" runat="server" AutoComplete="off" class="t" TextMode="Password" ></asp:TextBox>
    <p>Confirm Password</p>
    <asp:TextBox ID="confirmpassword" placeholder="Confirm Password" runat="server" AutoComplete="off" class="t" TextMode="Password"></asp:TextBox>
    <asp:Button Text="Registration" ID="Button1" runat="server" Class="b" onclick="Button1_Click"/>
    <a class="forgot" href="loginuser.aspx">Already Have an Account?</a>    
    <br />
    <br />
    <br />
    <center class="center"><asp:Label ID="Label1" runat="server" Text="" style="color:white ;padding-top:40px"></asp:Label></center>
    </div>

</asp:Content>

