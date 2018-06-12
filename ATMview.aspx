<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="ATMview.aspx.cs" Inherits="ATMview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<link rel="stylesheet" type="text/css" href="Bankssheet.css" />
<div class="back"></div>
<ul class="ul">
   <li class="li"><span>Street:</span><asp:DropDownList ID="filter" AppendDataBoundItems="true" runat="server" AutoPostBack="True" class="drop">
      <asp:ListItem>None</asp:ListItem>
       </asp:DropDownList>
   </li>
   <li class="li"><span>Bank:</span><asp:DropDownList ID="bank" AppendDataBoundItems="true" runat="server" AutoPostBack="True" class="drop">
      <asp:ListItem>None</asp:ListItem>
       </asp:DropDownList>
   </li>
</ul>
    <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal" 
        RepeatColumns="2" class="datalist" OnLoad="DataList1_Load">
    <ItemTemplate>
                <h2 class="h1"><%#Eval("name")%></h2>
        <asp:Image ID="Image1" class="im" runat="server" ImageUrl='<%#Eval("image") %>' style="width:300px; height:150px" />
        <div class="div">
        <pre class="pp"><%#Eval("address")%></pre>
        </div>
    </ItemTemplate>
    </asp:DataList>

    <div class="border" id="border" runat="server" visible=false>
    <asp:Label ID="Label1" runat="server" Text="Sorry Content not matched" CssClass="message1"></asp:Label>
    </div>
</asp:Content>

