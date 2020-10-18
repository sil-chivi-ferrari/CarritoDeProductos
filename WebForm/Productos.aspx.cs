using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Dominio;
using Negocio;

namespace WebForm
{
    public partial class Productos : System.Web.UI.Page
    {

        public List<Articulos> ListaArticulos { get; set; }
        public List<Articulos> listaBuscada;
        int extra;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            extra = Convert.ToInt32(Request.QueryString["extra"]);
            try
            {
                ListaArticulos = negocio.Listar();
                Session.Add("ListaArticulos", ListaArticulos);
                if (extra==0)
                {
                    listaBuscada = new List<Articulos>();
                    Session.Add("listaBuscar", listaBuscada);
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //Session.Add("ErrorEncontrado",ex.ToString());
                //Response.Redirect("Error.aspx");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (txtBuscar.Text == "")
                {
                    listaBuscada= negocio.Listar();
                    Session.Add("listaBuscar", listaBuscada);
                }
                else
                {
                    listaBuscada = ListaArticulos.FindAll(X => X.Nombre.ToUpper().Contains(txtBuscar.Text.ToUpper()) || X.Descripcion.ToUpper().Contains(txtBuscar.Text.ToUpper()) || X.Codigo.ToUpper().Contains(txtBuscar.Text.ToUpper()) || X.categoria.Descripcion.ToUpper().Contains(txtBuscar.Text.ToUpper()) || X.Marca.Descripcion.ToUpper().Contains(txtBuscar.Text.ToUpper()));
                    Session.Add("listaBuscar", listaBuscada); 
                    Response.Redirect("Productos.aspx?extra=1");
                }
            }
            catch (Exception ex)
            {
                
               // throw ex;
            }            


        }
    }
}