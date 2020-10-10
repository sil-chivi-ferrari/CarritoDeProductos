using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventana1
{
    public partial class fmAlta : Form
    {
        private Articulos art = null;
        public fmAlta()
        {
            InitializeComponent();
        }
        public fmAlta(Articulos Art, bool bandera)
        {
            InitializeComponent();
            art = Art;
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
            txtCodArt.Enabled = false;
            cbCategoria.Enabled = false;
            cbMarca.Enabled = false;
            txtImagen.Enabled = false;
            txtPrecio.Enabled = false;

        }
        public fmAlta(Articulos Art)
        {
            InitializeComponent();
            art = Art;

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio negocio = new ArticuloNegocio();
            //validaciones 
            //bool banderita = true;
            if (txtCodArt.TextLength == 0)
            {
                //banderita = false;
                txtCodArt.BackColor = Color.Red;
            }
            else
                txtCodArt.BackColor = System.Drawing.SystemColors.Control;

            if (txtDescripcion.TextLength == 0)
            {
                //banderita = false;
                txtDescripcion.BackColor = Color.Red;
            }
            else
                txtDescripcion.BackColor = System.Drawing.SystemColors.Control;
            if (txtNombre.TextLength == 0)
            {
                //banderita = false;
                txtNombre.BackColor = Color.Red;
            }
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
            if ( txtPrecio.TextLength == 0)
            {
                //banderita = false;
                txtPrecio.BackColor = Color.Red;    
            }
            else
                txtPrecio.BackColor = System.Drawing.SystemColors.Control;
            //if(banderita)

            if (txtCodArt.TextLength != 0 && txtDescripcion.TextLength != 0 && txtNombre.TextLength != 0 && txtPrecio.TextLength == 0 )
            {   

                if (art == null)
                    art = new Articulos();
                
                art.Codigo = txtCodArt.Text;
                art.Descripcion = txtDescripcion.Text;
                art.Nombre = txtNombre.Text;
                art.categoria = (Categoria)cbCategoria.SelectedItem;
                art.Marca = (Marca)cbMarca.SelectedItem;
                art.Imagen = txtImagen.Text;
                art.Precio = Convert.ToDecimal(txtPrecio.Text);
                    if (art.Id == 0)
                {
                    negocio.agregar(art);
                }
                else
                {
                    negocio.modificar(art);
                }

                MessageBox.Show("Operación realizada con exito REY/REYNA", "Exito");
           }
          // else { MessageBox.Show("Campos Incompletos o Invalidos", "Error Campos"); }
         Close();
        }

        private void fmAlta_Load(object sender, EventArgs e)
        {
            CategoriaNegocio Catnegocio = new CategoriaNegocio();
            cbCategoria.DataSource = Catnegocio.Listar();
            MarcaNegocio marcNegocio = new MarcaNegocio();
            cbMarca.DataSource = marcNegocio.Listar();
            cbCategoria.ValueMember = "Id";
            cbCategoria.DisplayMember = "Descripcion";
            cbMarca.ValueMember = "Id";
            cbMarca.DisplayMember = "Descripcion";
            cbCategoria.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;
            //parte s de marca iguales a esto
            if (art != null)
            {
                txtCodArt.Text = art.Codigo;
                txtNombre.Text = art.Nombre;
                txtDescripcion.Text = art.Descripcion;
                txtImagen.Text = art.Imagen;
                txtPrecio.Text = Convert.ToString(art.Precio);  
                cbCategoria.SelectedValue = art.categoria.Id;
                cbMarca.SelectedValue = art.Marca.Id;
                Text = "Modificacion De Registro";

            }
        

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.Cursor = Cursors.Arrow;
        }

        private void btnAceptar_MouseMove(object sender, MouseEventArgs e)
        {
            btnAceptar.Cursor = Cursors.Hand;

        }

        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCancelar.Cursor = Cursors.Hand;

        }
        
        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.Cursor = Cursors.Arrow;
            

        }
    }
}
