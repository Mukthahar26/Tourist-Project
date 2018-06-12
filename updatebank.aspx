<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatebank.aspx.cs" Inherits="updatebank" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="adminsheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>

    <center style="margin-top:50px">
          <table class="tbl">
      <tr>
          <td>
              <p>Services:</p>
          </td>
          <td><asp:DropDownList ID="services" class="drop" runat="server" AutoPostBack="True"></asp:DropDownList></td>
      </tr>


      <tr>
          <td>
              <p>Bank Name:</p>
          </td>
          <td>
              <asp:DropDownList ID="names" class="name" runat="server" AutoPostBack="true"></asp:DropDownList>
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
              <asp:FileUpload ID="fileup" runat="server" class="image" />
          </td>
      </tr>

      <tr>
          <td>
              <p>Street:</p>
          </td>
          <td>
              <asp:TextBox ID="street" class="name" runat="server" AutoComplete="off" ></asp:TextBox>
          </td>
      </tr>


      <tr>
          <td>
              <p>Address:</p>
          </td>
          <td>
              <asp:TextBox ID="address" runat="server" class="desc" TextMode="MultiLine" AutoComplete="off"></asp:TextBox>
          </td>
      </tr>

      <tr>
      <td></td>
          <td colspan="2">
              <asp:Button ID="submit" runat="server" Text="Submit" class="text" onclick="submit_Click" />
          </td>
      </tr>

      <tr>
      <td></td>
          <td colspan="2" align="center">
              <asp:Label ID="l" runat="server" class="label"></asp:Label>
          </td>
      </tr>

</table>
</center>
    </div>
    </form>
</body>
</html>
