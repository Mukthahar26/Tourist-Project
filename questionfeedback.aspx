<%@ Page Language="C#" AutoEventWireup="true" CodeFile="questionfeedback.aspx.cs" Inherits="questionfeedback" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="qeustionsheet.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="polling">
        <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
          <p class="p">1. How do you know about our Website?</p>
          <p class="q"><span>Ans.</span> <%#Eval("q1") %></p>
          <p class="p">2. Is there any thinging missing in our site?</p>
          <p class="q"><span>Ans.</span> <%#Eval("q2") %></p>
          <p class="p">3. Did your Experianced our services as Tourist?</p>
          <p class="q"><span>Ans.</span> <%#Eval("q3") %></p>
          <p class="p">4. Share your Experiance about our Tourist Guide?</p>
          <p class="q"><span>Ans.</span> <%#Eval("q4") %></p>
          <p class="p">5. Would you recommand our Website with your Friends?</p>
          <p class="q"><span>Ans.</span> <%#Eval("q5") %></p>
          <p class="p">6. Would your like to say anything?</p>
          <p class="q"><span>Ans.</span> <%#Eval("q6") %></p>
   </ItemTemplate>
   </asp:DataList>
    </div>
    </form>
</body>
</html>
