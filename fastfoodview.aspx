<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="fastfoodview.aspx.cs" Inherits="fastfoodview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<link href="fastfoodsheet.css" rel="stylesheet" type="text/css" />
<style type="text/css">
    .pic
    {
        background-image:url("fastfoodpic.jpg");
        width:100%;
        height:470px;
    }
</style>
    <div class="pic"></div>
    <asp:DataList ID="DataList1" OnLoad="DataList1_Load" runat="server" class="datalist">
    <ItemTemplate>
    <asp:Label ID="name" CssClass="h1" runat="server" Text='<%#Eval("name")%>'></asp:Label>
    <br />
    <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("image") %>' CssClass="im" />
    <br />
    <asp:LinkButton ID="comment" runat="server" OnClick="comment_Click" CssClass="reviews">User Reviews</asp:LinkButton>
    <br />
    <img src="call.png" width="13px" height="13px" class="add" /><h4 class="add">Contact:&nbsp;</h4><asp:HyperLink ID="HyperLink2" runat="server" text='<%#Eval("contact") %>' class="info"></asp:HyperLink>
    <br />
    <img src="timings1.png" width="13px" height="13px" class="add" /><h4 class="add">Timings:&nbsp;</h4><asp:HyperLink ID="HyperLink1" runat="server" text='<%#Eval("timings") %>' class="info"></asp:HyperLink>
    <br />
    <img src="address.png" width="13px" height="13px" class="add" alt="" /><h4 class="add">Address:</h4>
    <div class="dd"><div class="desc"><pre class="info"><%#Eval("address") %></pre></div>
         </div>
    </ItemTemplate>
    </asp:DataList>

    <div class="border" id="border" runat="server" visible=false>
    <asp:Label ID="Label1" runat="server" Text="Sorry Content not matched" CssClass="message1"></asp:Label>
    </div>
</asp:Content>

