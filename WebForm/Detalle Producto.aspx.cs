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
            
        }


    }
}
    