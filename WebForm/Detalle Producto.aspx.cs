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
        public Articulos articuloDetalle { get; set; }
        public List<Articulos> ListaDetalle { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocioAux = new ArticuloNegocio();
            List<Articulos> listaAux;
            try
            {
                listaAux = negocioAux.Listar();
               
                int idAux = Convert.ToInt32(Request.QueryString["idArticulo"]);
                articuloDetalle = listaAux.Find(x => x.Id == idAux);



            }
            catch (Exception)
            {

                Response.Redirect("Error.aspx");

            }


        }
        
    
    
    }
}