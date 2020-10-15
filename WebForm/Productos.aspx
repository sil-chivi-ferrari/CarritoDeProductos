<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebForm.Productos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Fiesta de productos</h1>
        <p>En esta sección vas a encontrar los productos que querés al mejor precio</p>
    </div>

    <div class="row">
        <%foreach (Dominio.Articulos item in ListaArticulos)
            {%>

        <div class="col-md-4">
            <div class="card" style="width: 18rem;">
                <img src="<%=item.Imagen %>" class="card-img-top" alt="alternative-text" width="280">
                <div class="card-body">
                    <h5 class="card-title"><% = item.Nombre %></h5>
                    <h5 class="card-title"><% = item.Precio %></h5>
                    <a href="#" class="btn btn-primary">Agregalo!</a>
                    <a href="Detalle Producto.aspx?idArticulo=<%=item.Id.ToString()%>" class="btn btn-primary">Detalle Producto</a>

                </div>
            </div>
        </div>

        <!-- LE PODRIAMOS PONER BORDER, Y PADDING, YO SE COMO SE HACE "SUPUESTAMETE" PERO ACA NO FUNCIONA-->
        <% } %>
    </div>


</asp:Content>
