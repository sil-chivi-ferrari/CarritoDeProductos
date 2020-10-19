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

                        <img src="<%=item.Imagen %>" class="card-img-top" alt="alternative-text" width="280">
                        <div class="card-body">
                            <h5 class="card-title" style="font-weight: bold"><% = item.Nombre %></h5>
                            <h5 class="card-title" style="font-weight: bold"><% = item.Precio %></h5>
                            <a href="Carrito.aspx?idArticulo=<%=item.Id.ToString()%>&extra=<%=1.ToString() %>" class="btn btn-danger">Eliminar</a>
                            <a href="Productos.aspx?" class="btn btn-primary">Volver</a>
                        </div>

                    </div>
                </div>
            </div>
            <% } %>
        </div>
        <div class="jumbotron" style="background-color:gold">
            <% if (ListaCarrito.Count() == 0)
                {
            %>
<%--https://i.pinimg.com/originals/c9/fe/1d/c9fe1d0e21080828820b1d6a150e0a1f.jpg--%>
            <h1>Ups, tu carro está vacío</h1>
           

            <%
                }

            %>
            <asp:Label Text="Cantidad Articulos:  " ID="lblCantidadItemsCarro" Font-Bold="true" Font-Size="X-Large" runat="server" />
            <br />
            <asp:Label Text="Importe Acumulado: $  " ID="lblImporteAcu" Font-Bold="true"  Font-Size="X-Large" runat="server" />
        </div>
    </div>
</asp:Content>
