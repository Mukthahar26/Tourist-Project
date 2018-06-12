<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="forgotpassword.aspx.cs" Inherits="forgotpassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<link href="fotgotpasswordsheet.css" rel="stylesheet" type="text/css" />

      <p class="head">Recover Password</p>
     <div class="border">
          <p class="tittle">Forgot your Password?</p>
          <p style="margin-left:150px; font-family:Arial">Enter your email address below and we will send you a link where you can enter a new password.</p>
          <p class="text">Enter your Email Address:</p>
          <asp:TextBox ID="box" runat="server" placeholder="Email Address" CssClass="box" AutoComplete="off"></asp:TextBox>
         <asp:Label ID="Label1" runat="server" CssClass="label"></asp:Label><br />
         <asp:Button ID="send" runat="server" Text="Recover Password" CssClass="button" 
              onclick="send_Click" />
     </div>

</asp:Content>
