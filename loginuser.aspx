<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="loginuser.aspx.cs" Inherits="loginuser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <link href="loginsheet.css" rel="stylesheet" type="text/css" />
   
<div id="log">
    <h2>Log In Here</h2>
    <p>User Name/Mail ID</p>
    <asp:TextBox ID="username1" runat="server" placeholder="User Name" AutoComplete="off" class="tt"></asp:TextBox>
    <p>Password</p>
    <asp:TextBox ID="password1" runat="server" TextMode=Password placeholder="Password" AutoComplete="off" class="tt" ></asp:TextBox>
    <asp:Button Text="Sign In" ID="Button1" runat="server" OnClick="Button1_Click" class="b"  />
    <a href="forgotpassword.aspx" class="forgot">Forget password?</a>
    <br /><br />
    <center><asp:Label ID="Label1" runat="server" class="label"></asp:Label></center>
    </div>
<script type="text/javascript">

    window.onunload = function () {
        window.history.backword(1);
    }

</script>
</asp:Content>

