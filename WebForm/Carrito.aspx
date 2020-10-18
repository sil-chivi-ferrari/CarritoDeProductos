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
<<<<<<< HEAD
=======
                        <img src="<%=item.Imagen %>" class="card-img-top" alt="alternative-text" width="280">
                        <div class="card-body">
                            <h5 class="card-title"style="font-weight: bold"><% = item.Nombre %></h5>
                            <h5 class="card-title"style="font-weight: bold"><% = item.Precio %></h5>
                            <a href="Carrito.aspx?idArticulo=<%=item.Id.ToString()%>&extra=<%=1.ToString() %>" class="btn btn-danger">Eliminar</a>
                            <a href="Productos.aspx?" class="btn btn-primary">Volver</a>
                        </div>
>>>>>>> 1b1137b6bdf89b0aa2dc880a76cda60fad42b4bb
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
