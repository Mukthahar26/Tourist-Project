<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="passwordrecovery.aspx.cs" Inherits="passwordrecovery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <link href="recoversheet.css" rel="stylesheet" type="text/css" />

<p class="head">Recover Your Password</p>
<div class="border">
<p class="p1">Enter new password:</p>
    <asp:TextBox ID="password" runat="server" class="password" TextMode="Password"></asp:TextBox>
<p class="p1">Confirm password:</p>
    <asp:TextBox ID="confirmpassword" runat="server" class="password" TextMode="Password"></asp:TextBox> <br />
    <asp:Button ID="save" runat="server" Text="Save" class="button" onclick="save_Click" />
    <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
</asp:Content>

