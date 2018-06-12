<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatetrain.aspx.cs" Inherits="updatetrain" %>

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
             <tr runat="server" id="tnoo">
           <td>
               <p>Train No:</p>
           </td>
           <td>
               <asp:TextBox ID="tno" runat="server" class="name" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>

         <tr runat="server" id="Tr3">
           <td>
               <p>Train Name:</p>
           </td>
           <td>
               <asp:TextBox ID="tname" runat="server" class="name" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>

       <tr id="depp" runat="server">
          <td>
             <p>Departure:</p>
          </td>
          <td>
              <asp:TextBox ID="dep" runat="server" class="name" AutoComplete="off" ></asp:TextBox>    
          </td>
       </tr>

       <tr id="Tr1" runat="server">
          <td>
             <p>departure time:</p>
          </td>
          <td>
              <asp:TextBox ID="deptime" runat="server" class="name" AutoComplete="off" ></asp:TextBox>    
          </td>
       </tr>

       <tr id="arrr" runat="server">
          <td>
              <p>Arrived:</p>
          </td>
          <td>
              <asp:TextBox ID="arr" runat="server" class="name" AutoComplete="off"></asp:TextBox> 
          </td>
       </tr>

       <tr id="Tr2" runat="server">
          <td>
             <p>Arrival Time:</p>
          </td>
          <td>
              <asp:TextBox ID="arrtime" runat="server" class="name" AutoComplete="off" ></asp:TextBox>    
          </td>
       </tr>

       <tr id="runonn" runat="server">
          <td>
             <p>Covering Routes:</p>
          </td>
          <td>
              <asp:TextBox ID="coveringroutes" runat="server" class="name" AutoComplete="off" ></asp:TextBox>    
          </td>
       </tr>

              <tr id="publishh" runat="server"> 
       <td></td>
          <td colspan="2">
              <asp:Button ID="Submit" runat="server" Text="Submit" class="text" OnClick="submit_click"/>
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
