<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle Producto.aspx.cs" Inherits="WebForm.Detalle_Producto" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      
    <div class="row">
     <%--   <%foreach (Dominio.Articulos item in ((List<Dominio.Articulos>)Session["ListaArticulos"])[x])
            {%>

        <div class="col-md-4">
            <div class="card" style="width: 18rem;">
                <img src="<%=item.Imagen %>" class="card-img-top" alt="alternative-text" width="280">
                <div class="card-body">
                    <h5 class="card-title"><% = item.Nombre %></h5>
                    <h5 class="card-title"><% = item.Precio %></h5>
                    <a href="#" class="btn btn-primary">Agregalo!</a>
                    <a href="Detalle Producto.aspx?idArticulo<%=item.Id.ToString()%>" class="btn btn-primary" id="btnDetalle">Detalle Producto</a>

                </div>
            </div>
        </div>
        <% } %>--%>


    </div>

</asp:Content>
