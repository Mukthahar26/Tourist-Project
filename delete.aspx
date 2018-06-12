<%@ Page Language="C#" AutoEventWireup="true" CodeFile="delete.aspx.cs" Inherits="delete" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="dataupdatesheet.css" rel="stylesheet" type="text/css" />
    <title></title>
    <script src="Scripts/jquery.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        function f() {
            var result = alert("Post was Deleted Successfully");
        }
    </script>    
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
        
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
        </asp:ScriptManager>
        
        
     
        <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
                <div class="border">
                     <span> <img src="arrows.png" alt="" class="img" /> </span> 
                     <asp:LinkButton ID="name" runat="server" Text='<%#Eval("name") %>' OnClick="name_click" CssClass="name"></asp:LinkButton>
                </div>
        </ItemTemplate>
        </asp:DataList>
        <asp:Label ID="Label1" runat="server" style="color:White"></asp:Label>


        <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
                <div class="border">
                     <span><img src="arrows.png" alt="" class="img" /></span>
                     <span class="bus">Bus No.</span> 
                     <asp:LinkButton ID="busno" runat="server" Text='<%#Eval("busno") %>' CssClass="bus"></asp:LinkButton>
                </div>
        </ItemTemplate>
        </asp:DataList>

    
    </div>
    </center>
    </div>
    </form>
</body>
</html>
