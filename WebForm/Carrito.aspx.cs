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

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocioAux = new ArticuloNegocio();
            List<Articulos> listaAux;

            extra = Convert.ToInt32(Request.QueryString["extra"]);
            idAux = Convert.ToInt32(Request.QueryString["idArticulo"]);
            listaAux = negocioAux.Listar();
            artBuscado = listaAux.Find(x => x.Id == idAux);
            if (idAux != 0 && extra == 1)
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
                catch (Exception ex )
                {
                    throw ex;
                    //Response.Redirect("Error.aspx");
                }
            }
            else if (idAux == 0)
            {
                ListaCarrito = (List<Articulos>) Session["ListArtAgregados"];

            }
            else
            {
                try
                {

                    if (Session["ListArtAgregados"] == null)
                    {
                        ListaCarrito = new List<Articulos>();// instancio con una lista vacia
                        ListaCarrito.Add(artBuscado);
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
    } 