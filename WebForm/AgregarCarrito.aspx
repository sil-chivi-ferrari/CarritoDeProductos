<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarCarrito.aspx.cs" Inherits="WebForm.AgregarCarrito" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Agregar al Carrito</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="row">
                <%foreach (Dominio.Articulos item in ListaCarrito)
                    {%>

                <div class="col-md-4">
                    <div class="card" style="width: 18rem;">
                        <img src="<%=item.Imagen %>" class="card-img-top" alt="alternative-text" width="280">
                        <div class="card-body">
                            <h5 class="card-title"><% = item.Nombre %></h5>
                            <h5 class="card-title"><% = item.Precio %></h5>

                            <a href="Detalle Producto.aspx?idArticulo=<%=item.Id.ToString()%>" class="btn btn-primary">Detalle Producto</a>


                        </div>
                    </div>
                </div>
                <% } %>
            </div>

        </div>
    </form>
</body>
</html>
