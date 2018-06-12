<%@ Page Title="" Language="C#" MasterPageFile="~/Administration.master" AutoEventWireup="true" CodeFile="taxiinsert.aspx.cs" Inherits="taxiinsert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

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

</asp:Content>

