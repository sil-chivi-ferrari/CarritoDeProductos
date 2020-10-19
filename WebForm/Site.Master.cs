using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Carro Carrin = new Carro();
            List<Articulos> aux = new List<Articulos>();
            if (Session["ListArtAgregados"] == null) //Si la lista no llegó a instanciarse
            {
                Session.Add("ListArtAgregados", aux);
                aux = ((List<Articulos>)Session["ListArtAgregados"]);
                Carrin.CantidadItems = aux.Count();
            }
            else
            {
                aux = ((List<Articulos>)Session["ListArtAgregados"]);
                Carrin.CantidadItems = aux.Count();

            }

            //foreach (Articulos item in aux)
            //{
            //    Carrin.ImporteTotal += item.Precio;
            //}
            lblCantidad.Text = ("Cantidad de articulos en el carro: " + Carrin.CantidadItems.ToString());
        }
    }
}