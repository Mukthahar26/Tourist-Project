<%@ Page Title="" Language="C#" MasterPageFile="~/Administration.master" AutoEventWireup="true" CodeFile="Transport.aspx.cs" Inherits="Transport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table class="tbl">
       
       <tr>
           <td>
               <p>Service:</p>
           </td>
           <td>
               <asp:DropDownList ID="services" class="drop" runat="server" AutoPostBack="True">
               </asp:DropDownList>
           </td>
       </tr>

       <tr runat="server" id="tnoo">
           <td>
               <p>Train No:</p>
           </td>
           <td>
               <asp:TextBox ID="tno" runat="server" class="name" AutoComplete="off"></asp:TextBox>
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

       <tr id="arrr" runat="server">
          <td>
              <p>Arrived:</p>
          </td>
          <td>
              <asp:TextBox ID="arr" runat="server" class="name" AutoComplete="off"></asp:TextBox> 
          </td>
       </tr>

       <tr id="runonn" runat="server">
          <td>
             <p>Run On:</p>
          </td>
          <td>
              <asp:TextBox ID="runon" runat="server" class="name" AutoComplete="off" ></asp:TextBox>    
          </td>
       </tr>


       <!------------------------------------------------------------------------------------------>


       <tr id="bnoo" runat="server">
           <td>
               <p>Bus No:</p>
           </td>
           <td>
               <asp:TextBox ID="bno" runat="server" class="name" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>


       <tr id="btypee" runat="server">
           <td> <p>Bus Type:</p></td>
           <td> <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                 <asp:ListItem>A/C</asp:ListItem>
                 <asp:ListItem>Non A/C</asp:ListItem>
               </asp:RadioButtonList> </td>
       </tr>


       <tr id="fromm" runat="server">
           <td>
               <p>From</p>
           </td>
           <td>
              <asp:TextBox ID="from" runat="server" class="name" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>


       <tr id="too" runat="server">
          <td>
              <p>To</p>
          </td>
          <td>
              <asp:TextBox ID="to" runat="server" class="name" AutoComplete="off"></asp:TextBox>
          </td>
       </tr>


       <tr id="coverr" runat="server">
           <td>
               <p>Covering Routes:</p>
           </td>
           <td>
               <asp:TextBox ID="coveringroutes" runat="server" class="name" AutoComplete="off"></asp:TextBox>
           </td>
       </tr>


       <tr id="publishh" runat="server"> 
       <td></td>
          <td colspan="2">
              <asp:Button ID="publish" runat="server" Text="Submit" class="text" onclick="publish_Click"/>
          </td>
       </tr>
      
       <tr>
       <td></td>
           <td colspan="2" align="center">
               <asp:Label ID="Label1" runat="server" class="label"></asp:Label>
           </td>
       </tr>


</table>

</asp:Content>

