<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updateshopping.aspx.cs" Inherits="updateshopping" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="adminsheet.css" rel="stylesheet" type="text/css" />
    <title></title>
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
             <asp:DropDownList class="drop" ID="services" runat="server" AutoPostBack="True"></asp:DropDownList>
         </td>          
      </tr>

      <tr>
          <td>
              <p>Name:</p>
          </td>
          <td>
              <asp:TextBox class="name" ID="name" runat="server" AutoComplete="off"></asp:TextBox>
          </td>
      </tr>

      <tr>
          <td>
          </td>
          <td>
              <asp:Image ID="Image1" runat="server" CssClass="images"/>
          </td>
      </tr>


      <tr>
          <td>
              <p>Image:</p>
          </td>
          <td>
              <asp:FileUpload ID="fileup" class="image" runat="server"/>
          </td>
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
              <asp:Button ID="submit" runat="server" Text="Submit" class="text" OnClick="submit_click" />
          </td>
      </tr>


      <tr>
      <td></td>
          <td colspan="2" align="center">
             <asp:Label ID="label" runat="server" class="label"></asp:Label>
          </td>
      </tr>

</table>
         </center>
    
    </div>
    </form>
</body>
</html>
