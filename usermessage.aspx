<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="usermessage.aspx.cs" Inherits="usermessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <link href="chatsheet.css" rel="stylesheet" type="text/css" />


    <div class="div" id="div" runat="server">
    <div id="cont" runat="server" class="cont">

    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release" EnablePartialRendering=true>   
    </asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

    <asp:DataList ID="dt" runat="server" class="dt" onitemdatabound="dt_ItemDataBound">
    <ItemTemplate>

    <p class="p" id="name" runat="server" style="margin-top:0px; display:none"><%#Eval("username") %></p>

    <asp:Label ID="adminid" runat="server" Text='<%#Eval("adminid") %>' style="display:none"></asp:Label>

    <div class="div1" id="div1" runat="server">
         <div id="message" runat="server" class="message"><%#Eval("message") %></div>
    </div>

    </ItemTemplate>
    </asp:DataList>
    
    <asp:Timer ID="Timer1" runat="server" OnTick="GetTime" Interval="1000" />
    </ContentTemplate>
    </asp:UpdatePanel>
    </div>
    
    <div class="div2">
    <asp:TextBox ID="message" runat="server" TextMode="MultiLine" placeholder="Type Message" class="textbox"></asp:TextBox>
    <asp:Button ID="send" runat="server" Text="Send" class="send" 
            onclick="send_click" />
            <asp:RequiredFieldValidator ControlToValidate="message" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Type message" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    </div>


</asp:Content>

