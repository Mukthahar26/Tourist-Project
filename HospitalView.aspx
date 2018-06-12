<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="HospitalView.aspx.cs" Inherits="HospitalView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="healthsheet.css" rel="stylesheet" type="text/css" />
<style type="text/css">
    
</style>
<div class="img1" ></div>
<ul class="ul">
   <li class="li"><span>Filter:</span><asp:DropDownList ID="filter" AppendDataBoundItems="true" runat="server" AutoPostBack="True" class="drop">
      <asp:ListItem>None</asp:ListItem>
       </asp:DropDownList>
   </li>
</ul>

<div class="main">

        <asp:DataList ID="DataList1" runat="server" OnLoad="DataList1_Load">
        <ItemTemplate>
        <div>
        <asp:Label ID="name" CssClass="h1" runat="server" Text='<%#Eval("name")%>'></asp:Label>
        <asp:Image ID="im" runat="server" CssClass="im" ImageUrl='<%#Eval("image") %>' />
        <asp:LinkButton ID="comment" runat="server" OnClick="comment_Click" CssClass="reviews">User Reviews</asp:LinkButton>
        <br />
        <div class="ppp">
        <img src="call.png" width="13px" height="13px" class="add"style="margin-top:40px"/><h4 class="add">Contact:&nbsp;</h4><asp:HyperLink ID="HyperLink2" runat="server" text='<%#Eval("contact") %>' class="info"></asp:HyperLink>
        <br />
        
           <img src="email.png" width="13px" height="13px" class="add" /><h4 class="add">Email:&nbsp;</h4><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Eval("email") %>' text='<%#Eval("email") %>' class="info"></asp:HyperLink>
           <br />
           <br />
           <img src="address.png" width="13px" height="13px" class="add" /><h4 class="add">Address:</h4>
           <div class="mar"><pre class="info"><%#Eval("address") %></pre></div>
         </div>
        <div id="div">
        <p class="pp"><%#Eval("description")%></p>
        </div>
        </ItemTemplate>
        </asp:DataList>
    </div>
    <div class="border" id="border" runat="server" visible=false>
    <asp:Label ID="Label1" runat="server" Text="Sorry Content not matched" CssClass="message1"></asp:Label>
    </div>
        <script src="Scripts/jquery.min.js" type="text/javascript"></script>
        <script src="Scripts/jquery.collapser.min.js" type="text/javascript"></script>
        <script type="text/javascript">
            $('.pp').collapser({ mode: "words", truncate: 20 });
        </script>
</asp:Content>

