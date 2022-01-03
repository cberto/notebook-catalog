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
    public partial class FormTipoMarca : Form
    {
        Marca mar;

        public FormTipoMarca()
        {
            InitializeComponent();
            // pnlModelos.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                Guardar();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Guardar()
        {
            if (txtNombre.Text == "" || txtAlias.Text == "" || nudCodigo.Value == 0)
                throw new Exception("Nombre, Alias o Codigo sin completar");
            /*Creamos el objeto con el constructor*/
            //TipoDocumento t = new TipoDocumento(txtNombre.Text, txtSigla.Text);

            /*Creamos el objeto y usamos las propiedades para completarlo*/
            Marca m = new Marca();
            m.Nombre = txtNombre.Text;
            m.Alias = txtAlias.Text;
            m.Codigo = Convert.ToInt32(nudCodigo.Value);

            if (ValidarMarca(m))
            {
                m.Guardar();
            }
            else
                throw new Exception("Valor repetido");
        }

        private bool ValidarMarca(Marca m)
        {
            if (Marca.Marcas != null)
                foreach (Marca tipoMarc in Marca.Marcas)
                {
                    if (tipoMarc.Nombre.ToUpper().Trim().Replace(".", "").Replace(" ", "") == 
                        m.Nombre.ToUpper().Trim().Replace(".", "").Replace(" ", "") || 
                        tipoMarc.Alias.ToUpper().Trim().Replace(".", "").Replace(" ", "") == 
                        m.Alias.ToUpper().Trim().Replace(".", "").Replace(" ", "") || 
                        tipoMarc.Codigo.ToString().ToUpper().Trim().Replace(".", "").Replace(" ", "") == 
                        m.Codigo.ToString().ToUpper().Trim().Replace(".", "").Replace(" ", ""))
                    {
                        return false;
                    }

                }
            if (mar == null)
                GuardarMarca();
            else
                ActualizarMarca();

            LimpiarDatos();
            pnlDatos.Enabled = false;

            return true;


        }
        private void GuardarMarca()
        {
            mar = new Marca();
            SetDatos(mar);
            mar.Guardar();
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = Marca.Marcas;
        }

        private void ActualizarMarca()
        {
            SetDatos(mar);

            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = Marca.Marcas;
        }

        private void SetDatos(Marca m)
        {
            m.Nombre = txtNombre.Text;
            m.Codigo = Convert.ToInt32(nudCodigo.Value);
            m.Alias = txtAlias.Text;
          //  m.TipoMarca = cmbTipoMarcas.SelectedItem as Marca;

        }

        private void GetDatos(Marca m)
        {
            txtNombre.Text = m.Nombre;
            txtAlias.Text = m.Alias;
            nudCodigo.Value = Convert.ToInt32(m.Codigo);
          //  cmbTipoMarcas.SelectedItem = n.TipoMarca;

        }

        private void panelTipoMarca_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            mar = null;
            LimpiarDatos();
            pnlDatos.Enabled = true;
        }

        private void LimpiarDatos()
        {
            txtNombre.Text = "";
            txtAlias.Text = "";
            nudCodigo.Value = 0;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            mar = ObtenerMarcaSeleccionado();
            LimpiarDatos();
            GetDatos(mar);
            pnlDatos.Enabled = true;
        }

        private void btnEliminarSeleccionado_Click(object sender, EventArgs e)
        {
            if (ObtenerMarcaSeleccionado() != null)
            {
                ObtenerMarcaSeleccionado().Eliminar();
                dgvMarcas.DataSource = null;
                dgvMarcas.DataSource = Marca.Marcas;

            }
            else
            {
                MessageBox.Show("No hay ninguna Marca seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mar = null;
            LimpiarDatos();
            pnlDatos.Enabled = false;
        }

        private void FormTipoMarca_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            Marca mar = ObtenerMarcaSeleccionado();
            if (mar == null)
                MessageBox.Show("No hay ninguna Notebook seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(mar.ToString(), "Seleccionado:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Marca ObtenerMarcaSeleccionado()
        {
            if (dgvMarcas.CurrentRow == null)
                return null;

            return dgvMarcas.CurrentRow.DataBoundItem as Marca;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = Notebook.Buscar(txtBuscar.Text);
        }
    }
    }

            