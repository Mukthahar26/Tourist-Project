<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="comment.aspx.cs" Inherits="comment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <link href="discussionsheet.css" rel="stylesheet" type="text/css" />
   <center><asp:Label ID="Label1" runat="server" CssClass="head"></asp:Label></center>
   <div class="div1">
    <asp:DataList ID="DataList1" runat="server">
    <ItemTemplate>

          <div class="namediv">
          <p class="p"><%#Eval("name") %></p>
          </div>

          <div class="datediv">
          <p class="dat"><%#Eval("date") %></p>
          </div>

          <div class="delete">
             
          </div>

          <div class="commentdiv">          
          <pre class="pre"><%#Eval("comment") %></pre>
          </div>

    </ItemTemplate>
    </asp:DataList>
    </div>
    <div class="div1">
    <span style="font-weight:bolder; font-size:18px; font-family:Arial">Name:&nbsp</span>
    <br />
    <asp:TextBox ID="name" runat="server" class="name1" AutoComplete="off"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" ErrorMessage="Please mention your name" ControlToValidate="name"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
    <span style="font-weight:bolder; font-size:18px; font-family:Arial">Comment:&nbsp</span>
    <br />
    <asp:TextBox ID="commentt" runat="server" TextMode="MultiLine" AutoComplete="off" CssClass="comment"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="Red" ErrorMessage="Type Your comment" ControlToValidate="commentt"></asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="submit" runat="server" Text="Submit" onclick="submit_Click" class="submit" />
    </div>


</asp:Content>

