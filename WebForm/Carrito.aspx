<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebForm.Carrito" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <%--    ESTO NO TIENE QUE IR COMO MATRIZ, SINO UNO ABAJO EL OTRO        --%>
        <div class="row">
            <p>Cantidad De Articulos  <%  %></p>
            <%foreach (Dominio.Articulos item in ListaCarrito)
                {%>

            <div class="col-md-4">
                <div class="row">
                    <div class="card" style="width: 18rem;">
                        <img src="<%=item.Imagen %>" class="card-img-top" alt="alternative-text" width="280">
                        <div class="card-body">
                            <h5 class="card-title"><% = item.Nombre %></h5>
                            <h5 class="card-title"><% = item.Precio %></h5>
                            <a href="Carrito.aspx?idArticulo=<%=item.Id.ToString()%>&extra=<%=1.ToString() %>" class="btn btn-danger">Eliminar</a>
                            <a href="Productos.aspx?" class="btn btn-primary">Volver</a>
                        </div>
                    </div>
                </div>
        </div>
        <% } %>
    </div>
    </div>
</asp:Content>
