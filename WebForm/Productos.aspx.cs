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
    public partial class Productos : System.Web.UI.Page
    {
        public List<Articulos> ListaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
                ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                ListaArticulos = negocio.Listar();
                Session.Add("ListaArticulos", ListaArticulos);
            }
            catch (Exception ex)
            {
                Session.Add("ErrorEncontrado",ex.ToString());
                Response.Redirect("Error.aspx");
               
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}