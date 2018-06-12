<%@ Page Title="" Language="C#" MasterPageFile="~/Administration.master" AutoEventWireup="true" CodeFile="Health.aspx.cs" Inherits="Health" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

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
               <asp:TextBox ID="name" class="name" runat="server" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>

       <tr>
           <td>
               <p>Image:</p>
           </td>
           <td>
               <asp:FileUpload ID="fileup" class="image" runat="server" />
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
               <p>Street:</p>
           </td>
           <td>
               <asp:TextBox ID="street" runat="server" class="name" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>

      <tr>
          <td><p>Address:</p></td>
          <td><asp:TextBox ID="address" runat="server" TextMode="MultiLine" AutoComplete="off" class="desc"></asp:TextBox></td>
      </tr>

     
       <tr id="de" runat="server">
           <td>
              <p>description:</p>
           </td>
           <td>
               <asp:TextBox ID="desc" runat="server" class="desc" TextMode="MultiLine" AutoComplete="off"></asp:TextBox>
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
               <asp:Label ID="label" class="label" runat="server"></asp:Label>
           </td>
       </tr>
</table>

</asp:Content>

