<%@ Page Language="C#" AutoEventWireup="true" CodeFile="feedbackview.aspx.cs" Inherits="feedbackview" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="feedbackviewsheet.css" rel="stylesheet" type="text/css" />
    <title></title>

</head>
<body>
<h1 class="h1">FeedBack Section</h1>
<form id="f1" runat="server">

<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>

        <asp:DataList ID="DataList1" runat="server" class="datalist">
        <ItemTemplate>
        <div class="div1">
      <!-- <asp:LinkButton ID="replay" runat="server" OnClick="replay_click" CssClass="replay">Replay</asp:LinkButton>
            <asp:LinkButton ID="replay1" runat="server" OnClick="replay1_click" CssClass="replay" Visible=false>Replay</asp:LinkButton>-->
            <p class="p" id="name" runat="server"><%#Eval("name") %></p>
            <asp:Label ID="Label1" runat="server" Text='<%#Eval("email") %>' Visible=false></asp:Label>
            <pre class="pre"><%#Eval("message") %></pre>
            <!--<div style="display:none" id="div" runat="server" class="div">
                <asp:TextBox ID="treplay" runat="server" CssClass="treplay" TextMode="MultiLine"></asp:TextBox><br /><br />
                <asp:Button ID="breplay" runat="server" Text="Replay" CssClass="breplay" OnClick="breplay_click"/>
                <asp:Label ID="success" runat="server" CssClass="s"></asp:Label>
            </div> -->

        </div>
        </ItemTemplate>
        </asp:DataList>
</ContentTemplate>
</asp:UpdatePanel>
        </form>
</body>

</html>
