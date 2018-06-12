<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="editfeedback.aspx.cs" Inherits="editfeedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <link href="polllingsheet.css" rel="stylesheet" type="text/css" />




<div class="polling">
  <p>1. How do you know about our Website?</p>
  <asp:TextBox ID="TextBox1" runat="server" textmode="MultiLine" CssClass="quetion"></asp:TextBox>

  <p>2. Is there any thinging missing in our site?</p>
  <span>(If Yes, shared your suggestion to improve our Website.)</span><br />
  <asp:TextBox ID="TextBox2" runat="server" textmode="MultiLine" CssClass="quetion"></asp:TextBox>

  <p>3. Did your Experianced our services as Tourist?</p>
  <span>(If Yes. then share your Experiance.)</span><br />
  <asp:TextBox ID="TextBox3" runat="server" textmode="MultiLine" CssClass="quetion"></asp:TextBox>

  <p>4. Share your Experiance about our Tourist Guide?</p>
  <asp:TextBox ID="TextBox4" runat="server" textmode="MultiLine" CssClass="quetion"></asp:TextBox>

  <p>5. Would you recommand our Website with your Friends?</p>
  <asp:TextBox ID="TextBox5" runat="server" textmode="MultiLine" CssClass="quetion"></asp:TextBox>

  <p>6. Would your like to say anything?</p>
  <span>(Please share your Opinion)</span><br />
  <asp:TextBox ID="TextBox6" runat="server" textmode="MultiLine" CssClass="quetion"></asp:TextBox>
  <br />
  <asp:Button ID="Button1" runat="server" OnClick="submit_click" Text="Submit" CssClass="sub" />

  <br />
  <br />
  <asp:Label ID="Label1" runat="server"></asp:Label>
  </div>


</asp:Content>

