<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="taxiconfirmation.aspx.cs" Inherits="taxiconfirmation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <link href="taxiinfosheet.css" rel="stylesheet" type="text/css" />

<div class="center">
        <h2>Vehicle Details</h2>
        <p class="p">
       <span style="font-weight:bolder" class="span">Vehicle Name:</span> <span id="vehicle" runat="server" class="span"></span><br />
       <span style="font-weight:bolder" class="span">Owner Name:</span> <span id="owner" runat="server" class="span"></span><br />
       <span style="font-weight:bolder" class="span">Contact:</span> <span id="cont" runat="server" class="span"></span><br />
       </p>
        <h2>Your Details</h2>
        <p class="p">
       <span style="font-weight:bolder" class="span">your Name:</span> <span id="name" runat="server" class="span"></span><br />
       <span style="font-weight:bolder" class="span">Your Contact:</span> <span id="Contact" runat="server" class="span"></span><br />
        </p>
    <asp:Button ID="booking" runat="server" Text="Request Booking"  CssClass="booking" OnClick="booking_click"/>
    <br />
    <asp:Label ID="success" runat="server" CssClass="success"></asp:Label>
    <br />
    <br />
    <br />

</div>


</asp:Content>

