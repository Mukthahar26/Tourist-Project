<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatetourism.aspx.cs" Inherits="updatetourism" %>

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
        <td><p>Sub Category:</p></td>
        <td><asp:DropDownList class="drop" ID="subcateg" runat="server" AutoPostBack="True">
        <asp:ListItem>Historical places</asp:ListItem>
        <asp:ListItem>Park</asp:ListItem>
        </asp:DropDownList> </td>
   </tr>


     <tr>
         <td><p>Name:</p></td>
         <td><asp:TextBox class="name" ID="tittle" runat="server" placeholder="Enter Tittle" AutoComplete="off"></asp:TextBox></td>
     </tr>

     <tr>
         <td>
         </td>
         <td> 
             <asp:Image ID="Image1" runat="server" CssClass="images" />
         </td>
     </tr>



     <tr>
         <td><p>Image:</p></td>
         <td><asp:FileUpload class="image" ID="fileup1" runat="server" placeholder="Select image" />
          <asp:Label class="label" ID="Label1" runat="server"></asp:Label></td>
     </tr>   


     <tr>
         <td><p>Description:</p></td>
         <td><asp:TextBox class="desc" ID="desc" runat="server" placeholder="Description" AutoComplete="off" TextMode="MultiLine"></asp:TextBox></td>
    </tr>


    <tr>
        <td></td>
        <td colspan="2"><asp:Button class="text" ID="publish"  runat="server"  Text="Publish" OnClick="publish_click"/></td>
    </tr>
    
    <tr>
        <td colspan="2"><asp:Label class="label" ID="label2" runat="server"></asp:Label></td>
    </tr>
    </table>

    </center>
    </div>
    </form>
</body>
</html>
