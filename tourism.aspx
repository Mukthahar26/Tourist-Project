<%@ Page Title="" Language="C#" MasterPageFile="~/Administration.master" AutoEventWireup="true" CodeFile="tourism.aspx.cs" Inherits="tourism" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <table class="tbl">   

   <tr>
        <td><p>Sub Category:</p></td>
        <td><asp:DropDownList class="drop" ID="subcateg" runat="server" AutoPostBack="True"></asp:DropDownList> </td>
   </tr>


     <tr>
         <td><p>Name:</p></td>
         <td><asp:TextBox class="name" ID="tittle" runat="server" placeholder="Enter Tittle" AutoComplete="off"></asp:TextBox></td>
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
        <td colspan="2"><asp:Button class="text" ID="publish"  runat="server"  Text="Publish" 
                onclick="publish_Click"/></td>
    </tr>
    
    <tr>
        <td colspan="2"><asp:Label class="label" ID="label2" runat="server"></asp:Label></td>
    </tr>
    </table>
</asp:Content>

