<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="touristview.aspx.cs" Inherits="touristview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="touristsheet.css" rel="stylesheet" type="text/css" />
<div class="img"></div>
<div class="main">

        <asp:DataList ID="DataList1" runat="server" OnLoad="DataList1_Load">
        <ItemTemplate>
        <asp:Label ID="name" CssClass="h1" runat="server" Text='<%#Eval("name")%>'></asp:Label>
        <asp:Image ID="im" runat="server" CssClass="im" ImageUrl='<%#Eval("image") %>' />
        <asp:LinkButton ID="comment" runat="server" OnClick="comment_Click" CssClass="reviews">User Reviews</asp:LinkButton>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <div id="div">
        <pre class="pp"><%#Eval("description")%></pre>
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

