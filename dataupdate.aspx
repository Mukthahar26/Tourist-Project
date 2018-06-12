<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dataupdate.aspx.cs" Inherits="dataupdate" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="dataupdatesheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:Button ID="home" runat="server" Text="HOME" CssClass="home" OnClick="home_click" />
   <center>
    <div>
    
        <asp:DropDownList ID="DropDownList6" runat="server" AutoPostBack="true" CssClass="drop" >
                   <asp:ListItem>Tourism</asp:ListItem>
                   <asp:ListItem>Banks</asp:ListItem>
                   <asp:ListItem>Bus</asp:ListItem>
                   <asp:ListItem>Company</asp:ListItem>
                   <asp:ListItem>Food</asp:ListItem>
                   <asp:ListItem>Hotels</asp:ListItem>
                   <asp:ListItem>Hospitals</asp:ListItem>
                   <asp:ListItem>Pharmacy</asp:ListItem>
                   <asp:ListItem>Shopping</asp:ListItem>
                   <asp:ListItem>Train</asp:ListItem>
                   <asp:ListItem>Taxi</asp:ListItem>
         </asp:DropDownList>

          
        <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
                <div class="border">
                     <span> <img src="arrows.png" alt="" class="img" /> </span> 
                     <asp:LinkButton ID="name" runat="server" Text='<%#Eval("name") %>' CssClass="name" OnClick="name_click"></asp:LinkButton>
                </div>
        </ItemTemplate>
        </asp:DataList>
        
        <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
                <div class="border">
                     <span><img src="arrows.png" alt="" class="img" /></span>
                     <span class="bus">Bus No.</span> 
                     <asp:LinkButton ID="busno" runat="server" Text='<%#Eval("busno") %>' CssClass="bus" OnClick="name_click"></asp:LinkButton>
                </div>
        </ItemTemplate>
        </asp:DataList>

    
    </div>
    </center>
    </form>
</body>
</html>
