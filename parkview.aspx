<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="parkview.aspx.cs" Inherits="parkview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<link href="touristsheet.css" rel="stylesheet" type="text/css" />
<style type="text/css">
.img1
{
    background-image:url("park2.jpeg");
    background-size:cover;
    width:100%;
    height:470px;
}
</style>
<div class="img1"></div>
        <div class="main">
        <asp:DataList ID="DataList1" runat="server" OnLoad="DataList1_Load">
        <ItemTemplate>
        <asp:Label ID="name" CssClass="h1" runat="server" Text='<%#Eval("name")%>'></asp:Label>
        <asp:Image ID="im" runat="server" ImageUrl='<%#Eval("image") %>' CssClass="im" />
        <asp:LinkButton ID="comment" runat="server" OnClick="comment_Click" CssClass="reviews">User Reviews</asp:LinkButton>
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
            $('.pp').collapser({ mode: "words", truncate: 40 });
        </script>
</asp:Content>

