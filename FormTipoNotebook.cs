using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico
{
    public partial class FormTipoNotebook : Form
    {
        Notebook note;

        public FormTipoNotebook()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
           Notebook note = ObtenerNotebookSeleccionado();
            if (note == null)
                MessageBox.Show("No hay ninguna Notebook seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(note.ToString(), "Seleccionado:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Notebook ObtenerNotebookSeleccionado()
        {
            if (dgvNotebooks.CurrentRow == null)
                return null;

            return dgvNotebooks.CurrentRow.DataBoundItem as Notebook;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvNotebooks.DataSource = null;
            dgvNotebooks.DataSource = Notebook.Buscar(txtBuscar.Text);
        }

        private void btnGuardarNotebooks_Click(object sender, EventArgs e)
        {
            if (note == null)
                GuardarNotebook();
            else
                ActualizarNotebook();

            LimpiarDatos();
            pnlDatos.Enabled = false;
        }
        private void GuardarNotebook()
        {
            note = new Notebook();
            SetDatos(note);
            note.Guardar();
            dgvNotebooks.DataSource = null;
            dgvNotebooks.DataSource = Notebook.Notebooks;
        }

        private void ActualizarNotebook()
        {
            SetDatos(note);

            dgvNotebooks.DataSource = null;
            dgvNotebooks.DataSource = Notebook.Notebooks;
        }

        private void SetDatos(Notebook n  )
        {
            n.Modelo = txtModelo.Text;
            n.Descripcion = txtDescripcion.Text;
            n.Precio= Convert.ToInt32(nudPrecio.Value);
            n.TipoMarca = cmbTipoMarcas.SelectedItem as Marca;
        }

        private void GetDatos(Notebook n)
        {
            txtModelo.Text = n.Modelo;
            txtDescripcion.Text = n.Descripcion;
            nudPrecio.Value = Convert.ToInt32(n.Precio);
            cmbTipoMarcas.SelectedItem = n.TipoMarca;

        }

        private void pnlModelos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormTipoNotebook_Load(object sender, EventArgs e)
        {
            CargarComboTipoMarcas();
        }
        private void CargarComboTipoMarcas()
        {
            cmbTipoMarcas.DataSource = null;
            cmbTipoMarcas.DataSource = Marca.Marcas;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            note = null;
            LimpiarDatos();
            pnlDatos.Enabled = true;
        }

        private void LimpiarDatos()
        {
            txtModelo.Text = "";
            txtDescripcion.Text = "";
             nudPrecio.Value = 0;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            note = ObtenerNotebookSeleccionado();
            LimpiarDatos();
            GetDatos(note);
            pnlDatos.Enabled = true;
        }


        private void btnTiposMarc_Click(object sender, EventArgs e)
        {
            FormTipoMarca f = new FormTipoMarca();
            f.ShowDialog();
            CargarComboTipoMarcas();
        }

        private void btnEliminarSeleccionado_Click(object sender, EventArgs e)
        {
            if (ObtenerNotebookSeleccionado() != null)
            {
                ObtenerNotebookSeleccionado().Eliminar();
                dgvNotebooks.DataSource = null;
                dgvNotebooks.DataSource = Notebook.Notebooks;

            }
            else
            {
                MessageBox.Show("No hay ninguna Notebook seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTiposMarca_Click(object sender, EventArgs e)
        {
            FormTipoMarca f = new FormTipoMarca();
            f.ShowDialog();
            CargarComboTipoMarcas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            note = null;
            LimpiarDatos();
            pnlDatos.Enabled = false;
        }

        private void pnlDatos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTipoMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudPrecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvNotebooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
