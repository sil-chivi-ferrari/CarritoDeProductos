<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebForm.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <%-- <h2><%: Title %></h2>--%>

    <div class="container center" style="text-align: center">
        <div class="jumbotron" style="background-color: gold">
            <h2>Acá se trabajó fuerte</h2>
            <h3>Esta es nuestra primera pagina web.</h3>
            <p>Mirala con cariño que todos empezamos por algún lugar...</p>
            <p>y este es el nuestro!</p>

            <div style="align-items: center">
                <img src="https://i.pinimg.com/236x/1a/be/00/1abe001e80e1492dd2df2b5096e7973d.jpg" class="card-img-top" alt="cris&chivi" width="300">

                <%-- <p><a href="https://github.com/sil-chivi-ferrari" class="btn btn-primary btn-lg">Buscame! &raquo;</a></p>--%>
                <div style="margin-top:20px">
                    <a class="btn btn-default" href="https://github.com/sil-chivi-ferrari">Chivi  &raquo;</a>
                    <a class="btn btn-default" href="https://github.com/CristianIglesias">Cristian &raquo;</a>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
