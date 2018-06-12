<%@ Page Title="" Language="C#" MasterPageFile="~/Administration.master" AutoEventWireup="true" CodeFile="hotels.aspx.cs" Inherits="hotels" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
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
         <td><p>Image:</p></td>
         <td><asp:FileUpload ID="fileup1" runat="server" class="image" placeholder="Select image" /></td>        
     </tr>   

     <tr>
     <td><p>Contact:</p></td>
     <td><asp:TextBox ID="contact" placeholder="Contact" runat="server" class="name" AutoComplete="off" ></asp:TextBox></td>
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
        <td  colspan="2"><asp:Button ID="publish" runat="server" class="text" Text="Submit" onclick="publish_Click"/></td>
    </tr>

    <tr>
        <td></td>
        <td><asp:Label ID="Label1" class="label" runat="server"></asp:Label></td>
    </tr>
    </table>
</asp:Content>

