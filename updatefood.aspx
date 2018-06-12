<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatefood.aspx.cs" Inherits="updatefood" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="adminsheet.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
    <div>

    <center>
          <table class="tbl">
       <tr>
           <td>
               <p>Services:</p>
           </td>
           <td>
               <asp:DropDownList ID="services" class="drop" runat="server">
               <asp:ListItem>Fast Food</asp:ListItem>
               <asp:ListItem>Cuisine</asp:ListItem>
               <asp:ListItem>Bekary</asp:ListItem>
               </asp:DropDownList>
           </td>
       </tr>

       <tr>
           <td>
              <p> Name:</p>
           </td>
           <td>
               <asp:TextBox class="name" ID="name" runat="server" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>

       <tr>
           <td>
           </td>
           <td>
               <asp:Image ID="Image1" CssClass="images" runat="server" />
           </td>
       </tr>

       <tr>
           <td> 
               <p>Image:</p>
           </td>
           <td>
               <asp:FileUpload class="image" ID="fileup" runat="server" />
           </td>
       </tr>

       <tr>
           <td>
               <p>contact:</p>
           </td>
           <td>
               <asp:TextBox class="name" ID="contact" runat="server" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>


       <tr>
           <td>
               <p>Street:</p>
           </td>
           <td>
               <asp:TextBox class="name" ID="street" runat="server" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>

       <tr>
           <td>
              <p>Timing:</p>
           </td>
           <td>
               <asp:TextBox class="name" ID="time" runat="server" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>

       <tr>
           <td>
               <p>Address:</p>
           </td>
           <td>
               <asp:TextBox ID="address" class="desc" runat="server" AutoComplete="off" TextMode="MultiLine"></asp:TextBox>
           </td>
       </tr>

       <tr>
       <td></td>
           <td colspan="2">
               <asp:Button ID="submit" runat="server" class="text" Text="Submit" OnClick="submit_click" />
           </td>
       </tr>

       <tr>
           <td></td>
           <td style="text-align:center"><asp:Label ID="Label1" runat="server" class="label"></asp:Label></td>
       </tr>
</table></center>
    </div>
    </form>
</body>
</html>
