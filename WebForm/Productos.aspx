<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebForm.Productos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="background-color: gold;  align-items: center">
        <asp:TextBox runat="server" placeholder="Buscar productos, marcas y más…" Style="border: none; background-color: antiquewhite; width: 300px; height: 25px" ID="txtBuscar" />
        <asp:Button class="btn btn-primary" Text="Buscar" ID="btnBuscar" OnClick="btnBuscar_Click" runat="server" />
        <h1>Fiesta de productos</h1>
        <p>En esta sección vas a encontrar los productos que querés al mejor precio</p>
    </div>

    <div class="row">

        <%
            if (((List<Dominio.Articulos>)Session["ListaBuscar"]).Count() == 0)
            {
                foreach (Dominio.Articulos item in ListaArticulos)
                {%>

        <div class="col-md-4">
            <div style="background-color: white">
                <div class="card" style="width: 18rem;">
                    <img src="<%=item.Imagen %>" class="card-img-top" alt="alternative-text" width="280">
                    <div class="card-body" style="margin-top: 20px">

                        <h5 class="card-title" style="font-weight: bold"><% = item.Nombre %></h5>
                        <h5 class="card-title" style="font-weight: bold"><% = item.Precio %></h5>
                        <div>
                            <a href="Detalle Producto.aspx?idArticulo=<%=item.Id.ToString()%>" class="btn btn-primary">Detalle Producto</a> <%-- El espacio es importante.--%>
                            <a href="Carrito.aspx?idArticulo=<%=item.Id.ToString()%>" class="btn btn-primary">Agregar</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <% }
            }
            else
            {
                foreach (Dominio.Articulos item in ((List<Dominio.Articulos>)Session["ListaBuscar"]))
                {%>

        <div class="col-md-4" >
            <div style="background-color: white">
                <div class="card" style="width: 18rem;">
                    <img src="<%=item.Imagen %>" class="card-img-top" alt="alternative-text" width="280">
                    <div class="card-body">
                        <h5 class="card-title" style="font-weight: bold"><% = item.Nombre %></h5>
                        <h5 class="card-title" style="font-weight: bold"><% = item.Precio %></h5>
                      
                            <a href="Detalle Producto.aspx?idArticulo=<%=item.Id.ToString()%>" class="btn btn-primary">Detalle Producto</a>
                         
                            
                        <a href="Carrito.aspx?idArticulo=<%=item.Id.ToString()%>" class="btn btn-primary">Agregar</a>
                        </div>
                    </div>
               
            </div>
        </div>

        <%  }
            } %>
    </div>


</asp:Content>
