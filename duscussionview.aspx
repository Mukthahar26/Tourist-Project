<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="duscussionview.aspx.cs" Inherits="duscussionview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <link href="discussionsheet.css" rel="stylesheet" type="text/css" />
   
   <div class="div1">
    <asp:DataList ID="DataList1" runat="server">
    <ItemTemplate>

          <div class="namediv">
          <p class="p"><%#Eval("name") %></p>
          </div>

          <div class="datediv">
          <p class="dat"><%#Eval("date") %></p>
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
    <asp:TextBox ID="name" runat="server" class="name"></asp:TextBox>
    <span style="font-weight:bolder; font-size:18px; font-family:Arial">Comment:&nbsp</span>
    <br />
    <asp:TextBox ID="comment" runat="server" TextMode="MultiLine" class="comment"></asp:TextBox>
    <br />
    <asp:Button ID="submit" runat="server" Text="Submit" onclick="submit_Click" class="submit" />
    </div>
</asp:Content>

