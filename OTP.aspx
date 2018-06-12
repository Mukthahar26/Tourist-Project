<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="OTP.aspx.cs" Inherits="OTP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<link href="otpsheet.css" rel="stylesheet" type="text/css" />

        <p class="p1">Please Wait, some times OTP will generate within 15min.</p>
    <div class="panel">
        <h4 class="h4">Enter Ysour OTP</h4>
    <center><asp:TextBox ID="otp" runat="server" class="text"></asp:TextBox></center>
    <center><asp:Button ID="submit" runat="server"  Text="Submit" class="sub" 
            onclick="submit_Click" />
        <asp:Button ID="resend" runat="server" Text="Resend" class="sub resend" 
            onclick="resend_Click" />
    </center>
    </div>
    <center><asp:Label class="p1" ID="fail" runat="server" style="color:red; margin-top:0px"></asp:Label>
   <asp:Label class="p1" ID="success" runat="server" style="color:Green"></asp:Label></center>

    <script src="Scripts/jquery.min.js" type="text/javascript"></script>
  <script type="text/javascript">
      $(document).ready(function () {
          Response.ExpiresAbsolute = DateTime.Now.AddDays(-1);
          Response.Expires = -1500;
          Response.CacheControl = "no-cache";
      });
  </script>

</asp:Content>

