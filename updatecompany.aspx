<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatecompany.aspx.cs" Inherits="updatecompany" %>

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
              <asp:DropDownList class="drop" ID="DropDownList1" runat="server" AutoPostBack="True">
              </asp:DropDownList>
          </td>
      </tr>

      <tr>
          <td>
              <p>Name:</p>
          </td>
          <td>
             <asp:TextBox ID="tittle" class="name" runat="server" AutoComplete="off"></asp:TextBox>
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
              <asp:FileUpload class="image" ID="fileup" runat="server" />
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
             <p>Fax No:</p>
          </td>
               <td><asp:TextBox ID="fax" class="name" runat="server" AutoComplete="off"></asp:TextBox>
          </td>
      </tr>

      <tr>
          <td>
              <p>URL:</p>
          </td>
          <td>
              <asp:TextBox ID="url" runat="server" class="name" AutoComplete="off"></asp:TextBox>
          </td>
      </tr>

      <tr>
          <td><p>Address:</p></td>
          <td><asp:TextBox ID="address" runat="server" TextMode="MultiLine" AutoComplete="off" class="desc"></asp:TextBox></td>
      </tr>

      <tr>
          <td>
              <p>Description:</p>
          </td>
          <td>
              <asp:TextBox ID="desc" runat="server" class="desc" AutoComplete="off" TextMode="MultiLine"></asp:TextBox>
          </td>
      </tr>
      
      <tr>
      <td></td>
          <td colspan="2">
              <asp:Button ID="publish" class="text" runat="server" Text="Submit" 
               OnClick="submit_click"/>
          </td>
      </tr>
      
      <tr>
          <td colspan="2" align="center">
              <asp:Label ID="label1" class="label" runat="server"></asp:Label>
          </td>
      </tr>

</table>
      
      </center>    
    </div>
    </form>
</body>
</html>
