﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle Producto.aspx.cs" Inherits="WebForm.Detalle_Producto" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<<<<<<< HEAD

    <div class="jumbotron">
        <h1>El Articulo que seleccionaste es:</h1>
        <div class="row">
          <%if (aMostrar != null)
              {
                  Dominio.Articulos item = aMostrar;%>
            <div class="col-md-4">
                <div class="card" style="width: 18rem;">
                    <img src="<%=item.Imagen %>" class="card-img-top" alt="alternative-text" width="280">
                    <div class="card-body">
                        <h5 class="card-title"><% = item.Nombre %></h5>
                        <h5 class="card-title"><% = item.Precio %></h5>
                        <h5 class="card-title"><%= item.categoria %></h5>
                        <h5 class="card-title"><%= item.Marca %></h5>
                        <a href="#" class="btn btn-primary">Agregalo!</a>
                        <a href="Productos.aspx" class="btn btn.primary">Volver</a>
          <%}
              else
              {
              }
              %>
                    </div>
                </div>
            </div>
        </div>
    </div>
=======
      



<%--    <div class="conteiner">
        <div class="jumbotron">

            <img src="<%=articuloDetalle.Imagen %>" alt="alternative-text" width="280">
            <h3 class ="display-4" = ><% = articuloDetalle.Nombre %></h3>
            <p class ="lead =" >Precio: $<% = articuloDetalle.Precio %></p>
            <div class="card-body">
            <a href="#" class="btn btn-primary">Agregalo</a>
                
  </div>
</div>
        </div>--%>

    <%--   <div class="row">
    

        <div class="col-md-4">
            <div class="card" style="width: 18rem;">
                <img src="<%=articuloDetalle.Imagen %>" class="card-img-top" alt="alternative-text" width="280">
                <div class="card-body">
                    <h5 class="card-title"><% = articuloDetalle.Nombre %></h5>
                    <h5 class="card-title"><% = articuloDetalle.Precio %></h5>
                     <h5 class="card-title"><% = articuloDetalle.Descripcion %></h5>--%>
                  <%--  <a href="#" class="btn btn-primary">Agregalo!</a>--%>
<%--                    <a href="Detalle Producto.aspx?idArticulo<%=articuloDetalle.Id.ToString()%>" class="btn btn-primary" id="btnDetalle">Detalle Producto</a>--%>

<%--                </div>
            </div>
        </div>
     


    </div>--%>
<%-->>>>>>> 4a2435cb67a3f23e8514004107fa4d90e0e60146--%>


</asp:Content>
