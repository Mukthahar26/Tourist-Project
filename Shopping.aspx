<%@ Page Title="" Language="C#" MasterPageFile="~/Administration.master" AutoEventWireup="true" CodeFile="Shopping.aspx.cs" Inherits="Shopping" %>

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
              <asp:TextBox class="name" ID="name" runat="server" AutoComplete="off"></asp:TextBox>
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
              <asp:Button ID="submit" runat="server" Text="Submit" class="text" onclick="submit_Click" />
          </td>
      </tr>


      <tr>
      <td></td>
          <td colspan="2" align="center">
             <asp:Label ID="label" runat="server" class="label"></asp:Label>
          </td>
      </tr>

</table>

</asp:Content>


