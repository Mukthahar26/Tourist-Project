<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatehotels.aspx.cs" Inherits="updatehotels" %>

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
         <td><p>Name:</p></td>
         <td><asp:TextBox ID="tittle" class="name" runat="server" placeholder="Name" AutoComplete="off"></asp:TextBox></td>
     </tr>


     <tr>
     <td><p>Hotel Type:</p></td>
         <td><asp:RadioButtonList ID="RadioButtonList1" class="list" runat="server" >
         <asp:ListItem>A/C</asp:ListItem>
         <asp:ListItem>Non A/C</asp:ListItem>
         <asp:ListItem>A/C and Non A/C</asp:ListItem>
         </asp:RadioButtonList></td>
     </tr>

     <tr>
     <td><p>Hotel Type:</p></td>
         <td><asp:RadioButtonList ID="RadioButtonList2" class="list" runat="server" >
         <asp:ListItem>3 Stars</asp:ListItem>
         <asp:ListItem>5 Stars</asp:ListItem>
         <asp:ListItem>7 Stars</asp:ListItem>
         </asp:RadioButtonList></td>
     </tr>

     <tr>
         <td></td>
         <td><asp:Image ID="Image1" runat="server"  CssClass="images"/></td>
     </tr>

     <tr>
         <td><p>Image:</p></td>
         <td><asp:FileUpload ID="fileup1" runat="server" class="image" placeholder="Select image" /></td>        
     </tr>   

     <tr>
     <td><p>Price:</p></td>
     <td><asp:TextBox ID="contact" placeholder="Price" runat="server" class="name" AutoComplete="off" ></asp:TextBox></td>
     </tr>
     

     <tr>
     <td><p>Price:</p></td>
     <td><asp:TextBox ID="price" placeholder="Price" runat="server" class="name" AutoComplete="off" ></asp:TextBox></td>
     </tr>

     <tr>
         <td><p>Description:</p></td>
         <td><asp:TextBox ID="desc" runat="server" class="desc" placeholder="Description" AutoComplete="off" TextMode="MultiLine"></asp:TextBox></td>
    </tr>


    <tr>
        <td align="center"></td>
        <td  colspan="2"><asp:Button ID="publish" runat="server" OnClick="submit_click" class="text" Text="Submit"/></td>
    </tr>

    <tr>
        <td></td>
        <td><asp:Label ID="Label1" class="label" runat="server"></asp:Label></td>
    </tr>
    </table>
        
        
        </center>

    </div>
    </form>
</body>
</html>
