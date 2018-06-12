<%@ Page Language="C#" AutoEventWireup="true" CodeFile="livechat.aspx.cs" Inherits="livechat" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="chatsheet.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <div class="div" id="div" runat="server">
    <div id="cont" runat="server" class="cont">

    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release" EnablePartialRendering=true>   
    </asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

    <asp:DataList ID="dt" runat="server" class="dt" onitemdatabound="dt_ItemDataBound">
    <ItemTemplate>

    <p class="p" id="name" runat="server" style="margin-top:0px; display:none"><%#Eval("username") %></p>

    <asp:Label ID="adminid" runat="server" Text='<%#Eval("adminid") %>' style="display:none"></asp:Label>

    <div class="div1" id="div1" runat="server">
         <div id="message" runat="server" class="message"><%#Eval("message") %></div>
    </div>

    </ItemTemplate>
    </asp:DataList>
    
    <asp:Timer ID="Timer1" runat="server" OnTick="GetTime" Interval="1000" />
    </ContentTemplate>
    </asp:UpdatePanel>
    </div>
    
    <div class="div2">
    <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="false">
    <ContentTemplate>
    <asp:TextBox ID="message" runat="server" TextMode="MultiLine" placeholder="Type Message" class="textbox"></asp:TextBox>
    <asp:Button ID="send" runat="server" Text="Send" class="send" 
            onclick="send_click" />
            <asp:RequiredFieldValidator ControlToValidate="message" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Type message" ForeColor="Red"></asp:RequiredFieldValidator>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="send" /> 
    </Triggers>
    </asp:UpdatePanel>
    </div>
    </div>
    </form>
    </body>



    <script src="Scripts/jquery.min.js" type="text/javascript"></script>
        <script type="text/javascript">
            window.onload = function () {
                var objDiv = document.getElementById("cont");
                objDiv.scrollTop = objDiv.scrollHeight;
            }
    </script>

</html>
