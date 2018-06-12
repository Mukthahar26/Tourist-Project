<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:smart cityConnectionString %>" 
            DeleteCommand="DELETE FROM [bus] WHERE [busno] = @busno" 
            InsertCommand="INSERT INTO [bus] ([id], [category], [subcategory], [busno], [bustype], [fromroute], [toroute], [coveringroutes]) VALUES (@id, @category, @subcategory, @busno, @bustype, @fromroute, @toroute, @coveringroutes)" 
            SelectCommand="SELECT * FROM [bus]" 
            UpdateCommand="UPDATE [bus] SET [id] = @id, [category] = @category, [subcategory] = @subcategory, [bustype] = @bustype, [fromroute] = @fromroute, [toroute] = @toroute, [coveringroutes] = @coveringroutes WHERE [busno] = @busno">
            <DeleteParameters>
                <asp:Parameter Name="busno" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="id" Type="Int32" />
                <asp:Parameter Name="category" Type="String" />
                <asp:Parameter Name="subcategory" Type="String" />
                <asp:Parameter Name="busno" Type="String" />
                <asp:Parameter Name="bustype" Type="String" />
                <asp:Parameter Name="fromroute" Type="String" />
                <asp:Parameter Name="toroute" Type="String" />
                <asp:Parameter Name="coveringroutes" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="id" Type="Int32" />
                <asp:Parameter Name="category" Type="String" />
                <asp:Parameter Name="subcategory" Type="String" />
                <asp:Parameter Name="bustype" Type="String" />
                <asp:Parameter Name="fromroute" Type="String" />
                <asp:Parameter Name="toroute" Type="String" />
                <asp:Parameter Name="coveringroutes" Type="String" />
                <asp:Parameter Name="busno" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>


        <asp:GridView ID="GridView1" runat="server" AutoGenerateEditButton=true>
                <Columns>
                     <asp:CommandField ShowDeleteButton="True" />
                     <asp:TemplateField>
                     <EditItemTemplate>
                         <asp:Label ID="Lb" runat="server" Text='<%#Eval("id") %>'></asp:Label>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:DropDownList ID="ddl" runat="server" AutoPostBack=true DataTextField='<%#Eval("id") %>'>
                         </asp:DropDownList>
                     </ItemTemplate>
                     </asp:TemplateField>
                </Columns>
        </asp:GridView>
       
    </div>
    </form>
</body>
</html>
