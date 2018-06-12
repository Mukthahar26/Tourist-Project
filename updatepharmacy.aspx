<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatepharmacy.aspx.cs" Inherits="updatepharmacy" %>

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
               <p>Name:</p>
           </td>
           <td>
               <asp:TextBox ID="name" class="name" runat="server" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>

       <tr>
           <td>
           </td>
           <td>
               <asp:Image ID="Image1" runat="server" CssClass="images" />
           </td>
       </tr>

       <tr>
           <td>
               <p>Image:</p>
           </td>
           <td>
               <asp:FileUpload ID="fileup" class="image" runat="server" />
           </td>
       </tr>

       <tr>
          <td>
              <p>Email:</p>
          </td>
          <td>
              <asp:TextBox class="name" ID="mail" runat="server" AutoComplete="off"></asp:TextBox>
          </td>
      </tr>

      <tr>
         <td>
             <p>Contact No:</p>
         </td>
         <td>
            <asp:TextBox ID="contact" class="name" runat="server" AutoComplete="off"></asp:TextBox>
         </td>
      </tr>


      <tr>
           <td>
               <p>Street:</p>
           </td>
           <td>
               <asp:TextBox ID="street" runat="server" class="name" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>

      <tr>
          <td><p>Address:</p></td>
          <td><asp:TextBox ID="address" runat="server" TextMode="MultiLine" AutoComplete="off" class="desc"></asp:TextBox></td>
      </tr>   
    

       <tr>
       <td></td>
           <td colspan="2">
               <asp:Button ID="submit" runat="server" Text="Submit" class="text" OnClick="submit_click" />
           </td>
       </tr>

       <tr>
       <td></td>
           <td colspan="2" align="center">
               <asp:Label ID="label" class="label" runat="server"></asp:Label>
           </td>
       </tr>
</table>
</center>
    </div>
    </form>
</body>
</html>
