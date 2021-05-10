<%@ Page Title="Contact" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.vb" Inherits="WebApplication1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <p>Your contact page.</p>

    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399</address>
    <address>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </address>
    <address>
        <asp:TextBox ID="TextBox1" runat="server" Width="279px"></asp:TextBox>
    </address>
    <address>
        <br />
        <abbr title="Phone">:<asp:Button ID="Button1" runat="server" Text="Button" Width="288px" />
        </abbr>
        &nbsp;</address>

    <address>
        <strong>Support:</strong><a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong><a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
