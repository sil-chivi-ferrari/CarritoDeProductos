using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;
using System.Runtime.InteropServices;

namespace Ventana1
{
    
    public partial class Form1 : Form
    {
        private List<Articulos> listaOriginal;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();

        }
        protected void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaOriginal = negocio.Listar();
            dgvGrilla.DataSource = listaOriginal;
            dgvGrilla.Columns[0].Visible = false;
            dgvGrilla.Columns[1].Visible = false;
            dgvGrilla.Columns[3].Visible = false;
            dgvGrilla.Columns[4].Visible = false;
            dgvGrilla.Columns[6].Visible = false;
        }

        private void dgvGrilla_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Articulos art = (Articulos)dgvGrilla.CurrentRow.DataBoundItem;
                pbImagen.Load(art.Imagen);
            }
            catch (Exception ex)
            {
            }
        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            fmAlta alta = new fmAlta(); // creo la ventana
            alta.ShowDialog(); // abro la ventana
            Cargar();
        }         
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulos art;
            art = (Articulos)dgvGrilla.CurrentRow.DataBoundItem;
            fmAlta modificar = new fmAlta(art);
            modificar.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {   
            DialogResult resultado  = MessageBox.Show("Está Seguro que desea Eliminar el articulo?", "ATENCION!", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Accion Cancelada", "Abortado");
            }
            else
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.eliminar(((Articulos)dgvGrilla.CurrentRow.DataBoundItem).Id);
                Cargar();
            }
            
        }

        
        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtFiltro.Text == "")
            {
                dgvGrilla.DataSource = listaOriginal;
            }
            else
            {
                List<Articulos> listaFiltrada = listaOriginal.FindAll(X => X.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || X.Descripcion.ToUpper().Contains(txtFiltro.Text.ToUpper() )|| X.Codigo.ToUpper().Contains(txtFiltro.Text.ToUpper()) || X.categoria.Descripcion.ToUpper().Contains(txtFiltro.Text.ToUpper()) || X.Marca.Descripcion.ToUpper().Contains(txtFiltro.Text.ToUpper()));
                dgvGrilla.DataSource = listaFiltrada;
            }
        }

        private void dgvGrilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulos art;
            art = (Articulos)dgvGrilla.CurrentRow.DataBoundItem;
            fmAlta modificar = new fmAlta(art, false);
            modificar.ShowDialog();
            Cargar();
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_MouseMove(object sender, MouseEventArgs e)
        {
            btnAgregar.Cursor = Cursors.Hand;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.Cursor = Cursors.Arrow;
        }

        private void btnModificar_MouseMove(object sender, MouseEventArgs e)
        {
            btnModificar.Cursor = Cursors.Hand;
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.Cursor = Cursors.Arrow;

        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.Cursor = Cursors.Arrow;
        }

        private void btnEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            btnEliminar.Cursor = Cursors.Hand;
        }

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulos art;
            art = (Articulos)dgvGrilla.CurrentRow.DataBoundItem;
            fmAlta modificar = new fmAlta(art, false);
            modificar.ShowDialog();
            Cargar();
        }
    }
}
