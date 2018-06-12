<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="contact.aspx.cs" Inherits="contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<link href="contactussheet.css" rel="stylesheet" type="text/css" />
<div id="img"></div>
<div id="div">
    <p class="head">Get In Touch</p>
    <p class="p1">please fill out the quick form and we will be in touch lightening speed.</p>
    
    
    <div id="offset" runat="server">
        <asp:TextBox ID="name" runat="server" placeholder="Name" class="text" AutoComplete="off" required></asp:TextBox>
        
        <asp:TextBox ID="email" runat="server" placeholder="Your Email Address" AutoComplete="off" class="text" required></asp:TextBox>     
        
        <asp:TextBox ID="message" runat="server" placeholder="Messsage" TextMode="MultiLine" AutoComplete="off" class="text1" required></asp:TextBox>
        
        <asp:Button ID="submit" runat="server" Text="Submit" BorderStyle="None" class="submit" onclick="submit_Click" />
        <br />
        <asp:Label ID="label" runat="server" class="lab"></asp:Label>
    </div>

    <div id="main">
    <div id="div1">
         <center><h1 class="h1">Connect with Us:</h1>
         <p class="p1">If any query please feel free to contact Us:</p>
         <p class="p1" style=" font-weight:600">Email us at: mukthahar897@gmail.com</p>
         </center>
    </div>
    <div id="div2">
    <center>
            <h1 class="h1">Our HelpLine:</h1>
         <p class="p">Manager: +91 8688028066</p>
         <p>Branch: +1800 8887 4444</p>
    </center>
    </div>
    <div id="div3">
    <center>
         <h1 class="h1">Address:</h1>
    </center>
    <div id="div5" style="margin-left:360px; margin-bottom:30px">
         <p>Tours & Travel Agency</p>
         <p>D/O 21/36,</p>
         <p>High-Tech City,</p>
         <p>Hyderabad.</p>
    </div>
    </div>
    </div>
    </div>
</asp:Content>

