using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class Detalle_Producto : System.Web.UI.Page
    {
        ////<<<<<<< HEAD
        public Articulos aMostrar { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            string idItem = Request.QueryString["idArticulo"];
            try
            {
                aMostrar = ((List<Articulos>)Session.Contents["ListaArticulos"]).Find(X => X.Id.ToString().Contains(idItem));
            }
            catch (Exception ex)
            {

                Session.Add("ErrorEncontrado", ex.ToString());
                Response.Redirect("Error.aspx");
                throw;
            }
            //=======
            //            public articulos articulodetalle { get; set; }
            //public list<articulos> listadetalle { get; set; }
            //protected void page_load(object sender, eventargs e)
            //{
            //    articulonegocio negocioaux = new articulonegocio();
            //    list<articulos> listaaux;
            //    try
            //    {
            //        listaaux = negocioaux.listar();
            //        int idaux = convert.toint32(request.querystring["?idarticulo"]);
            //        articulodetalle = new articulos();
            //        articulodetalle = listaaux.find(x => x.id == idaux);



            //    }
            //    catch (exception)
            //    {

            //        response.redirect("error.aspx");

            //    }


            ////>>>>>>> 4a2435cb67a3f23e8514004107fa4d90e0e60146
        }


    }
}
    