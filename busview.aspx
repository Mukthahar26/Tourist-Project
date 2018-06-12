<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="busview.aspx.cs" Inherits="busview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <link href="bussheet.css" rel="stylesheet" type="text/css" />
   

    <div class="pic"></div>

    <center>
    <table class="tb">
           <tr>
               <td style="padding-right:20px"><span>Search Area:&nbsp;</span><asp:TextBox ID="to" AutoComplete="off" runat="server" CssClass="busfrom"></asp:TextBox></td>
               <td><asp:Button ID="search" runat="server" Text="Search" CssClass="b" AutoPostBack=true OnClick="search_click" /></td>
           </tr>
    </table>
    </center>

    <asp:GridView CssClass="grid" AutoGenerateColumns="false" ID="GridView1" 
        runat="server" onload="GridView1_Load">
       <Columns>
       <asp:TemplateField HeaderText="Bus No">
       <ItemTemplate>
       <p class="busno"><%#Eval("busno") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       <asp:TemplateField HeaderText="Bus Type">
       <ItemTemplate>
       <p class="bustype"><%#Eval("bustype") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       <asp:TemplateField HeaderText="From">
       <ItemTemplate>
       <p class="from"><%#Eval("fromroute") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       <asp:TemplateField HeaderText="Dep. Time">
       <ItemTemplate>
       <p class="dep"><%#Eval("departure") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       <asp:TemplateField HeaderText="To">
       <ItemTemplate>
       <p class="to"><%#Eval("toroute") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       <asp:TemplateField HeaderText="Arr. Time">
       <ItemTemplate>
       <p class="dep"><%#Eval("arrival") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       <asp:TemplateField HeaderText="Covering Routes">
       <ItemTemplate>
       <p class="cover"><%#Eval("coveringroutes") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       </Columns>
    </asp:GridView>
    
    <div class="border" id="border" runat="server" visible=false>
    <asp:Label ID="Label1" runat="server" Text="Sorry Content not matched" CssClass="message1"></asp:Label>
    </div>

</asp:Content>

