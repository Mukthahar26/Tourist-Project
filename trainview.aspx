<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="trainview.aspx.cs" Inherits="trainview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <link href="trainsheet.css" rel="stylesheet" type="text/css" />
   
<div class="pic"></div>

    <center> 
    <table class="tb">
           <tr>
               <td class="from"><span>Search Area:&nbsp;</span><asp:TextBox ID="from" runat="server" AutoComplete="off" CssClass="trainfrom"></asp:TextBox></td>
               <td><asp:Button ID="search" runat="server" Text="Search" AutoPostBack=true CssClass="b" OnClick="search_click" /></td>
           </tr>
    </table>
    </center>


    
    <asp:GridView CssClass="grid" AutoGenerateColumns="false" ID="GridView1" 
        runat="server" onload="GridView1_Load1">
       <Columns>
       <asp:TemplateField HeaderText="Train No">
       <ItemTemplate>
       <p class="no"><%#Eval("no") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       
       <asp:TemplateField HeaderText="Source">
       <ItemTemplate>
       <p class="source"><%#Eval("source") %></p>
       </ItemTemplate>
       </asp:TemplateField>

       <asp:TemplateField HeaderText="dep. Time">
       <ItemTemplate>
       <p class="dep"><%#Eval("departure") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       
       <asp:TemplateField HeaderText="Destination">
       <ItemTemplate>
       <p class="destination"><%#Eval("destination") %></p>
       </ItemTemplate>
       </asp:TemplateField>

       <asp:TemplateField HeaderText="arr. Time">
       <ItemTemplate>
       <p class="dep"><%#Eval("arrival") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       
       <asp:TemplateField HeaderText="Covering Routes">
       <ItemStyle Wrap="true" Width="450px" />
       <ItemTemplate>
       <p class="runon"></p>
           <asp:Label ID="Label2" CssClass="runon" runat="server" Text='<%#Eval("runon") %>'></asp:Label>
       </ItemTemplate>
       </asp:TemplateField>
       </Columns>
    </asp:GridView>

    <div class="border" id="border" runat="server" visible=false>
    <asp:Label ID="Label1" runat="server" Text="Sorry Content not matched" CssClass="message1"></asp:Label>
    </div>
    
</asp:Content>

