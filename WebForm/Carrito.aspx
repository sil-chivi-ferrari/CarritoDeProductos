<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebForm.Carrito" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div class="row">
            <%foreach (Dominio.Articulos item in ListaCarrito)

                {

            %>
            <div class="col-md-4">
                <div class="row">
                    <div class="card" style="width: 18rem;">
                    </div>
                </div>
            </div>
            <% } %>
        </div>
        <div class="jumbotron">
            <% if (ListaCarrito.Count() == 0)
                {
            %>

                <h1>Ups, tu carro está empty Rey</h1>
                <p>acá tenés que venir al final, para pagar crack.</p>
            
            <%
                }

            %>
            <asp:Label Text="Cantidad Articulos  " ID="lblCantidadItemsCarro" Font-Bold="true" runat="server" />
            <br />
            <asp:Label Text="Importe Acumulado  " ID="lblImporteAcu" Font-Bold="true" runat="server" />
        </div>
    </div>
</asp:Content>
