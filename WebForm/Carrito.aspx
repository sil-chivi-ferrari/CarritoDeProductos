<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebForm.Carrito" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div>
            <div class="row">
                <%foreach (Dominio.Articulos item in ListaCarrito)
                    {%>

                <div class="col-md-4">
                    <div class ="row">
                        <p>Cantidad De Articulos = <% %></p>
                    <div class="card" style="width: 18rem;">

                        <img src="<%=item.Imagen %>" class="card-img-top" alt="alternative-text" width="280">
                        <div class="card-body">
                            <h5 class="card-title"><% = item.Nombre %></h5>
                            <h5 class="card-title"><% = item.Precio %></h5>
                            <a href="Detalle Producto.aspx?idArticulo=<%=item.Id.ToString()%>" class="btn btn-primary">Detalle Producto</a>

                            </div>
                        </div>
                    </div>

                </div>
                <% } %>
            </div>
</div>
</asp:Content>
