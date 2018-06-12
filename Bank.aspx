<%@ Page Title="" Language="C#" MasterPageFile="~/Administration.master" AutoEventWireup="true" CodeFile="Bank.aspx.cs" Inherits="Bank" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table class="tbl">
      <tr>
          <td>
              <p>Services:</p>
          </td>
          <td><asp:DropDownList ID="services" class="drop" runat="server" AutoPostBack="True"></asp:DropDownList></td>
      </tr>


      <tr>
          <td>
              <p>Bank Name:</p>
          </td>
          <td>
              <asp:DropDownList ID="names" class="name" runat="server" AutoPostBack="true"></asp:DropDownList>
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
              <p>Street:</p>
          </td>
          <td>
              <asp:TextBox ID="street" class="name" runat="server" AutoComplete="off" ></asp:TextBox>
          </td>
      </tr>


      <tr>
          <td>
              <p>Address:</p>
          </td>
          <td>
              <asp:TextBox ID="address" runat="server" class="desc" TextMode="MultiLine" AutoComplete="off"></asp:TextBox>
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
              <asp:Label ID="l" runat="server" class="label"></asp:Label>
          </td>
      </tr>


</table>

</asp:Content>

