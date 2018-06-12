<%@ Page Title="" Language="C#" MasterPageFile="~/Administration.master" AutoEventWireup="true" CodeFile="Companies.aspx.cs" Inherits="Companies" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table class="tbl">
      <tr>
          <td>
              <p>Services:</p>
          </td>
          <td>
              <asp:DropDownList class="drop" ID="DropDownList1" runat="server" AutoPostBack="True">
              </asp:DropDownList>
          </td>
      </tr>

      <tr>
          <td>
              <p>Name:</p>
          </td>
          <td>
             <asp:TextBox ID="tittle" class="name" runat="server" AutoComplete="off"></asp:TextBox>
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
             <p>Fax No:</p>
          </td>
               <td><asp:TextBox ID="fax" class="name" runat="server" AutoComplete="off"></asp:TextBox>
          </td>
      </tr>

      <tr>
          <td>
              <p>URL:</p>
          </td>
          <td>
              <asp:TextBox ID="url" runat="server" class="name" AutoComplete="off"></asp:TextBox>
          </td>
      </tr>

      <tr>
          <td><p>Address:</p></td>
          <td><asp:TextBox ID="address" runat="server" TextMode="MultiLine" AutoComplete="off" class="desc"></asp:TextBox></td>
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
              <asp:Button ID="publish" class="text" runat="server" Text="Submit" 
                  onclick="publish_Click" />
          </td>
      </tr>
      
      <tr>
          <td colspan="2" align="center">
              <asp:Label ID="label1" class="label" runat="server"></asp:Label>
          </td>
      </tr>

</table>

</asp:Content>

