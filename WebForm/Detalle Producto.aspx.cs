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
            //            public Articulos articuloDetalle { get; set; }
            //public List<Articulos> ListaDetalle { get; set; }
            //protected void Page_Load(object sender, EventArgs e)
            //{
            //    ArticuloNegocio negocioAux = new ArticuloNegocio();
            //    List<Articulos> listaAux;
            //    try
            //    {
            //        listaAux = negocioAux.Listar();
            //        int idAux = Convert.ToInt32(Request.QueryString["?idArticulo"]);
            //        articuloDetalle = new Articulos();
            //        articuloDetalle = listaAux.Find(x => x.Id == idAux);



            //    }
            //    catch (Exception)
            //    {

            //        Response.Redirect("Error.aspx");

            //    }


            ////>>>>>>> 4a2435cb67a3f23e8514004107fa4d90e0e60146
        }


    }
}
    