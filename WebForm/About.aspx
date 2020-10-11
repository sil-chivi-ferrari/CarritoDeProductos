<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebForm.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Aca seguro contemos que hicimos esta aplicacion para la facultad.</h3>
    <p>Contando un poquito, quienes somos nosotres.. medio al pedo, no? .</p>
    <p>pero parece que hay que acostumbrarse.</p>

    <div class="card" style="width: 18rem;">
        <img src="https://i.pinimg.com/236x/1a/be/00/1abe001e80e1492dd2df2b5096e7973d.jpg" class="card-img-top" alt="...">

        <%-- <p><a href="https://github.com/sil-chivi-ferrari" class="btn btn-primary btn-lg">Buscame! &raquo;</a></p>--%>
        <a class="btn btn-default" href="https://github.com/sil-chivi-ferrari">Chivi  &raquo;</a>
        <a class="btn btn-default" href="https://github.com/sil-chivi-ferrari">Cristian &raquo;</a>
    </div>

</asp:Content>
