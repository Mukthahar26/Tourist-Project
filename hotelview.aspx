<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="hotelview.aspx.cs" Inherits="hotelview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="hotelsheet.css" rel="stylesheet" type="text/css" />
<div class="img1" ></div>
<ul class="ul">
  <li class="li"><span>Price:</span><asp:DropDownList ID="price" AppendDataBoundItems="true" runat="server" AutoPostBack="True" class="drop">
      <asp:ListItem>None</asp:ListItem>
      <asp:ListItem>1000 To 2000</asp:ListItem>
      <asp:ListItem>2000 To 3000</asp:ListItem>
      <asp:ListItem>3000 To 4000</asp:ListItem>
      <asp:ListItem>4000 To 6000</asp:ListItem>
      <asp:ListItem>Above 6000</asp:ListItem>
       </asp:DropDownList>
   </li>
   <li class="li"><span>type:</span><asp:DropDownList ID="type" AppendDataBoundItems="true" runat="server" AutoPostBack="True" class="drop">
      <asp:ListItem>None</asp:ListItem>
       </asp:DropDownList>
   </li>
   <li class="li"><span>Stars:</span><asp:DropDownList ID="stars" AppendDataBoundItems="true" runat="server" AutoPostBack="True" class="drop">
   <asp:ListItem>None</asp:ListItem>
   </asp:DropDownList>
   </li>
</ul>

<div class="main">

        <asp:DataList ID="DataList1" runat="server" OnLoad="DataList1_Load">
        <ItemTemplate>
        <div>
        <asp:Label ID="name" CssClass="h1" runat="server" Text='<%#Eval("name")%>'></asp:Label>
        <asp:Image ID="im" CssClass="im" runat="server" ImageUrl='<%#Eval("image") %>' />
        <asp:LinkButton ID="comment" runat="server" OnClick="comment_Click" CssClass="reviews">User Reviews</asp:LinkButton>
        <img src="stars.png" width="15px" height="15px" class="add" style="margin-top:30px" /><h4 class="add">Stars:&nbsp;</h4><asp:HyperLink ID="HyperLink1" runat="server" Text='<%#Eval("Stars") %>' class="info">Url:</asp:HyperLink>
           <br />
        <div class="ppp">
        <img src="call.png" width="13px" height="13px" class="add" /><h4 class="add">Contact:&nbsp;</h4><asp:HyperLink ID="HyperLink2" runat="server" text='<%#Eval("contact") %>' class="info"></asp:HyperLink>
           <br />
           <img src="money.png" width="13px" height="13px" class="add" /><h4 class="add">Price:&nbsp;</h4><asp:HyperLink ID="url" runat="server" Text='<%#Eval("price") %>' class="info">Url:</asp:HyperLink>
           <br />
           <img src="money.png" width="13px" height="13px" class="add" /><h4 class="add">Type:&nbsp;</h4><asp:HyperLink ID="HyperLink3" runat="server" Text='<%#Eval("type") %>' class="info">Url:</asp:HyperLink>
           <br />
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

