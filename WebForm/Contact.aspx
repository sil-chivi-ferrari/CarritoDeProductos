<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebForm.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Les amigues que hicieron esta bella web:</h3>
    <address>
        Lavalle xx<br />
        San Fernando. Buenos Aires.Argentina<br />
        <abbr title="Phone">P:</abbr>
        +54-9-1131790514
    </address>

    <address>
        <strong>Cristian Iglesias:</strong>   <a href="mailto:chivife@gmail.com">chivife@gmail.com</a><br />
        <strong>Silvana Ferrari:</strong> <a href="mailto:Marketing@example.com">cristian_iglesias@gmail.com</a>
    </address>
</asp:Content>
