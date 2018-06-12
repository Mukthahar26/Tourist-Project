<%@ Page Title="" Language="C#" MasterPageFile="~/Administration.master" AutoEventWireup="true" CodeFile="Food.aspx.cs" Inherits="Food" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table class="tbl">
       <tr>
           <td>
               <p>Services:</p>
           </td>
           <td>
               <asp:DropDownList ID="services" class="drop" runat="server"></asp:DropDownList>
           </td>
       </tr>

       <tr>
           <td>
              <p> Name:</p>
           </td>
           <td>
               <asp:TextBox class="name" ID="name" runat="server" AutoComplete="off"></asp:TextBox>
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
               <p>contact:</p>
           </td>
           <td>
               <asp:TextBox class="name" ID="contact" runat="server" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>


       <tr>
           <td>
               <p>Street:</p>
           </td>
           <td>
               <asp:TextBox class="name" ID="street" runat="server" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>

       <tr>
           <td>
              <p>Timing:</p>
           </td>
           <td>
               <asp:TextBox class="name" ID="time" runat="server" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>

       <tr>
           <td>
               <p>Address:</p>
           </td>
           <td>
               <asp:TextBox ID="address" class="desc" runat="server" AutoComplete="off" TextMode="MultiLine"></asp:TextBox>
           </td>
       </tr>

       <tr>
       <td></td>
           <td colspan="2">
               <asp:Button ID="submit" runat="server" class="text" Text="Submit" onclick="submit_Click" />
           </td>
       </tr>

       <tr>
           <td></td>
           <td style="text-align:center"><asp:Label ID="Label1" runat="server" class="label"></asp:Label></td>
       </tr>
</table>
</asp:Content>

