<%@ Page Language="C#" AutoEventWireup="true" CodeFile="taxiupdate.aspx.cs" Inherits="taxiupdate" %>

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
              <p>Vehicle Name:</p>
          </td>
          <td>
              <asp:TextBox ID="TextBox1" class="name" runat="server" AutoComplete="off" ></asp:TextBox>
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
              <p>Owner Name:</p>
          </td>
          <td>
              <asp:TextBox ID="name" class="name" runat="server" AutoComplete="off" ></asp:TextBox>
          </td>
      </tr>


      <tr>
          <td>
              <p>Contact:</p>
          </td>
          <td>
              <asp:TextBox ID="contact" runat="server" CssClass="name" AutoComplete="off"></asp:TextBox>
          </td>
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
              <asp:Label ID="l" runat="server" class="label"></asp:Label>
          </td>
      </tr>


</table>
</center>

    </div>
    </form>
</body>
</html>
