<%@ Page Language="C#" AutoEventWireup="true" CodeFile="usersdetails.aspx.cs" Inherits="usersdetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="usersheet.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
    <div>

    <div><span>Enter Email:</span>
        <asp:TextBox ID="search" runat="server" CssClass="filter" AutoComplete="Off">
        </asp:TextBox>
        <asp:Button ID="bsearch" runat="server" Text="Search" CssClass="bsearch" 
            onclick="bsearch_Click" />

    </div>
       
         <asp:GridView CssClass="grid" AutoGenerateColumns="false" ID="GridView1" runat="server">
       <Columns>
       <asp:TemplateField HeaderText="User ID">
       <ItemTemplate>
       <p class="id"><%#Eval("id") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       <asp:TemplateField HeaderText="First Name">
       <ItemTemplate>
       <p class="fname"><%#Eval("firstname") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       <asp:TemplateField HeaderText="Last Name">
       <ItemTemplate>
       <p class="lname"><%#Eval("lastname") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       <asp:TemplateField HeaderText="E-Mail">
       <ItemTemplate>
       <p class="email"><%#Eval("email") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       <asp:TemplateField HeaderText="Phone No">
       <ItemTemplate>
       <p class="phone"><%#Eval("phone") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       <asp:TemplateField HeaderText="Gender">
       <ItemTemplate>
       <p class="gender"><%#Eval("gender") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       <asp:TemplateField HeaderText="Professionality">
       <ItemTemplate>
       <p class="pro"><%#Eval("professionality") %></p>
       </ItemTemplate>
       </asp:TemplateField>
       </Columns>
    </asp:GridView>
    </div>
    </form>
</body>
</html>
