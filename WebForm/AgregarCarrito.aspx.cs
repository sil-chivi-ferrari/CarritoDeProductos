using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebForm
{
    public partial class Agregar : System.Web.UI.Page
    {
        public Articulos artBuscado { get; set; }
        public List<Articulos> ListaCarrito { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocioAux = new ArticuloNegocio();
            List<Articulos> listaAux;
            try
            {
                listaAux = negocioAux.Listar();

                int idAux = Convert.ToInt32(Request.QueryString["idArticulo"]);
                artBuscado = listaAux.Find(x => x.Id == idAux);

                if (Session["ListArtAgregados"] == null)
                {
                    ListaCarrito = new List<Articulos>();// instancio con una lista vacia
                    Session.Add("ListArtAgregados", ListaCarrito);
                }
                else
                {
                    ListaCarrito = (List<Articulos>)Session["ListArtAgregados"];
                    ListaCarrito.Add(artBuscado);
                    Session["ListArtAgregados"] = ListaCarrito;
                }


            }
            catch (Exception)
            {

                Response.Redirect("Error.aspx");

            }

        }
    }
}