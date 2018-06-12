<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="Companyiew.aspx.cs" Inherits="Companyiew" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<link rel="Stylesheet" href="companysheet.css" type="text/css" />

<div class="img1" ></div>

<div class="main">

        <asp:DataList ID="DataList1" runat="server" OnLoad="DataList1_Load">
        <ItemTemplate>
        <div>
        <asp:Label ID="name" CssClass="h1" runat="server" Text='<%#Eval("name")%>'></asp:Label>
        <asp:Image ID="im" runat="server" ImageUrl='<%#Eval("image") %>' CssClass="im" />
        <asp:LinkButton ID="comment" runat="server" OnClick="comment_Click" CssClass="reviews">User Reviews</asp:LinkButton>
        <div class="ppp">
        <img src="call.png" width="13px" height="13px" class="add" /><h4 class="add">Contact:&nbsp;</h4><asp:HyperLink ID="HyperLink2" runat="server" text='<%#Eval("contact") %>' class="info"></asp:HyperLink>
           <br />
           <img src="fax.png" width="13px" height="13px" class="add" /><h4 class="add">Fax:&nbsp;</h4><asp:HyperLink ID="HyperLink3" runat="server" text='<%#Eval("fax") %>' class="info"></asp:HyperLink>
           <br />
           <img src="email.png" width="13px" height="13px" class="add" /><h4 class="add">Email:&nbsp;</h4><asp:HyperLink ID="HyperLink1" runat="server" Text='<%#Eval("email") %>' class="info">Url:</asp:HyperLink>
           <br />
           <img src="website.png" width="13px" height="13px" class="add" /><h4 class="add">Url:&nbsp;</h4><asp:HyperLink ID="url" runat="server" Text='<%#Eval("url") %>' class="info">Url:</asp:HyperLink>
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

