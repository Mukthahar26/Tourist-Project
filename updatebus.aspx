<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatebus.aspx.cs" Inherits="updatebus" %>

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
               <p>Bus No:</p>
           </td>
           <td>
               <asp:TextBox ID="bno" runat="server" class="name" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>


       <tr>
           <td> <p>Bus Type:</p></td>
           <td> <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                 <asp:ListItem>A/C</asp:ListItem>
                 <asp:ListItem>Non A/C</asp:ListItem>
               </asp:RadioButtonList> </td>
       </tr>


       <tr>
           <td>
               <p>From</p>
           </td>
           <td>
              <asp:TextBox ID="from" runat="server" class="name" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>

       <tr>
           <td> <p>Dep. Time:</p></td>
           <td> <asp:TextBox ID="deptime" runat="server" class="name" AutoComplete="off"></asp:TextBox> </td>
       </tr>

       <tr>
          <td>
              <p>To</p>
          </td>
          <td>
              <asp:TextBox ID="to" runat="server" class="name" AutoComplete="off"></asp:TextBox>
          </td>
       </tr>

       <tr>
           <td> <p>Arr. Time:</p></td>
           <td> <asp:TextBox ID="arrtime" runat="server" class="name" AutoComplete="off"></asp:TextBox> </td>
       </tr>

       <tr id="coverr" runat="server">
           <td>
               <p>Covering Routes:</p>
           </td>
           <td>
               <asp:TextBox ID="coveringroutes" runat="server" class="name" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>


       <tr id="publishh" runat="server"> 
       <td></td>
          <td colspan="2">
              <asp:Button ID="submit" runat="server" OnClick="submit_click" Text="Submit" class="text"/>
          </td>
       </tr>
       <tr>
       <td></td>
           <td colspan="2" align="center">
               <asp:Label ID="Label1" runat="server" class="label"></asp:Label>
           </td>
       </tr>
</table>

</center>
    </div>
    </form>
</body>
</html>
