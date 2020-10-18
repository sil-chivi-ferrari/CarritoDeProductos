using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebForm
{
    public partial class Carrito : System.Web.UI.Page
    {

        public Articulos artBuscado;
        public List<Articulos> ListaCarrito;
        int idAux;
        int extra;
        Carro Carrin;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocioAux = new ArticuloNegocio();
            Carrin = new Carro();
            List<Articulos> listaAux;
            extra = Convert.ToInt32(Request.QueryString["extra"]);
            idAux = Convert.ToInt32(Request.QueryString["idArticulo"]);
            listaAux = negocioAux.Listar();
            artBuscado = listaAux.Find(x => x.Id == idAux);
            if (idAux != 0 && extra == 1)///Esto Elimina.
            {
                try
                {
                    ListaCarrito = ((List<Articulos>)Session["ListArtAgregados"]);
                    foreach (Articulos Item in ListaCarrito)
                    {
                        if (Item.Id == idAux)
                        {
                            ListaCarrito.Remove(Item);
                            Session.Add("ListArtAgregados", ListaCarrito);
                            Response.Redirect("Carrito.aspx");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                    //Response.Redirect("Error.aspx");
                }
            }
            else if (idAux == 0)//Esto es cuando entra sin querer agregar, tipo para ver los articulos que estén cargados en el carro.
            {
                if (Session["ListArtAgregados"] == null) //Si la lista no llegó a instanciarse
                {
                    ListaCarrito = new List<Articulos>();
                    Session["ListArtAgregados"] = ListaCarrito;
                }
                else
                
                { ListaCarrito = (List<Articulos>)Session["ListArtAgregados"]; }

            }
            else //Esto Agrega items al carro.
            {
                try
                {

                    if (Session["ListArtAgregados"] == null) //Si es el Primer item.
                    {
                        ListaCarrito = new List<Articulos>();
                        ListaCarrito.Add(artBuscado);
                        Session["ListArtAgregados"] = ListaCarrito;

                    }
                    else //Si el carro ya tenía algo adentro.
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
            foreach (Articulos item in ListaCarrito)
            {
                Carrin.ImporteTotal += item.Precio;
                Carrin.CantidadItems++;
            }
            lblCantidadItemsCarro.Text += (Carrin.CantidadItems);
            lblImporteAcu.Text += (Carrin.ImporteTotal);
        }
        }
    } 