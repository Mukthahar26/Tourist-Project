<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="taxi.aspx.cs" Inherits="taxi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<link rel="stylesheet" type="text/css" href="taxisheet.css" />


<div style="background-image:url('taxi.jpg'); width:100%; height:420px;"></div>
<ul>
<li class="li"><span>Vehicle:</span><asp:DropDownList ID="filter" AppendDataBoundItems="true" runat="server" AutoPostBack="True" class="drop">
      <asp:ListItem>None</asp:ListItem>
       </asp:DropDownList>
   </li>
</ul>


    <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal" 
        RepeatColumns="2" class="datalist">
    <ItemTemplate>
    <div class="div">
                <h2 id="name" runat="server" class="h1"><%#Eval("name") %></h2>
                <asp:Image ID="Image1" class="im" runat="server" ImageUrl='<%#Eval("image") %>' style="width:300px; height:150px" />
                
                <p id="owner" runat="server" class="p1"><%#Eval("owner") %></p>
                <p id="contact" runat="server" class="p2"><%#Eval("contact") %></p>
                <asp:Button ID="sms" runat="server" Text="Send Booking Request" CssClass="sms" OnClick="sms_click" />
    </div>
    </ItemTemplate>
    </asp:DataList>

    <div class="border" id="border" runat="server" visible=false>
    <asp:Label ID="Label1" runat="server" Text="Sorry Content not matched" CssClass="message1"></asp:Label>
    </div>



</asp:Content>

