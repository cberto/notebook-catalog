namespace TrabajoPractico
{
    partial class FormTipoNotebook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoNotebook));
            this.pnlModelos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnTiposMarca = new System.Windows.Forms.Button();
            this.lblMarcaTipo = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblModelo = new System.Windows.Forms.Label();
            this.btnGuardarNotebooks = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbTipoMarcas = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarSeleccionado = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvNotebooks = new System.Windows.Forms.DataGridView();
            this.pnlModelos.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotebooks)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlModelos
            // 
            this.pnlModelos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlModelos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlModelos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlModelos.Controls.Add(this.label1);
            this.pnlModelos.Controls.Add(this.pnlDatos);
            this.pnlModelos.Controls.Add(this.btnNuevo);
            this.pnlModelos.Controls.Add(this.btnModificar);
            this.pnlModelos.Controls.Add(this.btnEliminarSeleccionado);
            this.pnlModelos.Controls.Add(this.btnBuscar);
            this.pnlModelos.Controls.Add(this.txtBuscar);
            this.pnlModelos.Controls.Add(this.dgvNotebooks);
            this.pnlModelos.Location = new System.Drawing.Point(2, 1);
            this.pnlModelos.Name = "pnlModelos";
            this.pnlModelos.Size = new System.Drawing.Size(531, 591);
            this.pnlModelos.TabIndex = 11;
            this.pnlModelos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlModelos_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 91;
            this.label1.Text = "Listado de Notebooks";
            // 
            // pnlDatos
            // 
            this.pnlDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatos.Controls.Add(this.btnCancelar);
            this.pnlDatos.Controls.Add(this.btnTiposMarca);
            this.pnlDatos.Controls.Add(this.lblMarcaTipo);
            this.pnlDatos.Controls.Add(this.nudPrecio);
            this.pnlDatos.Controls.Add(this.lblModelo);
            this.pnlDatos.Controls.Add(this.btnGuardarNotebooks);
            this.pnlDatos.Controls.Add(this.lblPrecio);
            this.pnlDatos.Controls.Add(this.txtDescripcion);
            this.pnlDatos.Controls.Add(this.lblDescripcion);
            this.pnlDatos.Controls.Add(this.cmbTipoMarcas);
            this.pnlDatos.Controls.Add(this.txtModelo);
            this.pnlDatos.Enabled = false;
            this.pnlDatos.Location = new System.Drawing.Point(0, 316);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(531, 275);
            this.pnlDatos.TabIndex = 90;
            this.pnlDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDatos_Paint);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::TrabajoPractico.Properties.Resources.close;
            this.btnCancelar.Location = new System.Drawing.Point(264, 211);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(33, 43);
            this.btnCancelar.TabIndex = 81;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnTiposMarca
            // 
            this.btnTiposMarca.FlatAppearance.BorderSize = 0;
            this.btnTiposMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiposMarca.Image = global::TrabajoPractico.Properties.Resources.search_24x24;
            this.btnTiposMarca.Location = new System.Drawing.Point(211, 28);
            this.btnTiposMarca.Name = "btnTiposMarca";
            this.btnTiposMarca.Size = new System.Drawing.Size(24, 23);
            this.btnTiposMarca.TabIndex = 80;
            this.btnTiposMarca.UseVisualStyleBackColor = true;
            this.btnTiposMarca.Click += new System.EventHandler(this.btnTiposMarca_Click);
            // 
            // lblMarcaTipo
            // 
            this.lblMarcaTipo.AutoSize = true;
            this.lblMarcaTipo.Location = new System.Drawing.Point(41, 33);
            this.lblMarcaTipo.Name = "lblMarcaTipo";
            this.lblMarcaTipo.Size = new System.Drawing.Size(37, 13);
            this.lblMarcaTipo.TabIndex = 13;
            this.lblMarcaTipo.Text = "Marca";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(84, 86);
            this.nudPrecio.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 20);
            this.nudPrecio.TabIndex = 12;
            this.nudPrecio.ValueChanged += new System.EventHandler(this.nudPrecio_ValueChanged);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(36, 60);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "Modelo";
            // 
            // btnGuardarNotebooks
            // 
            this.btnGuardarNotebooks.FlatAppearance.BorderSize = 0;
            this.btnGuardarNotebooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNotebooks.Image = global::TrabajoPractico.Properties.Resources.save3;
            this.btnGuardarNotebooks.Location = new System.Drawing.Point(225, 211);
            this.btnGuardarNotebooks.Name = "btnGuardarNotebooks";
            this.btnGuardarNotebooks.Size = new System.Drawing.Size(33, 43);
            this.btnGuardarNotebooks.TabIndex = 11;
            this.btnGuardarNotebooks.UseVisualStyleBackColor = true;
            this.btnGuardarNotebooks.Click += new System.EventHandler(this.btnGuardarNotebooks_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(41, 88);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(84, 116);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(174, 79);
            this.txtDescripcion.TabIndex = 7;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(14, 119);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // cmbTipoMarcas
            // 
            this.cmbTipoMarcas.FormattingEnabled = true;
            this.cmbTipoMarcas.Location = new System.Drawing.Point(84, 30);
            this.cmbTipoMarcas.Name = "cmbTipoMarcas";
            this.cmbTipoMarcas.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoMarcas.TabIndex = 11;
            this.cmbTipoMarcas.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMarcas_SelectedIndexChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(84, 58);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 6;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::TrabajoPractico.Properties.Resources.add_24x24;
            this.btnNuevo.Location = new System.Drawing.Point(17, 275);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(31, 25);
            this.btnNuevo.TabIndex = 89;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Image = global::TrabajoPractico.Properties.Resources.content;
            this.btnModificar.Location = new System.Drawing.Point(54, 275);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(35, 28);
            this.btnModificar.TabIndex = 88;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarSeleccionado
            // 
            this.btnEliminarSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarSeleccionado.FlatAppearance.BorderSize = 0;
            this.btnEliminarSeleccionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarSeleccionado.Image = global::TrabajoPractico.Properties.Resources.delete;
            this.btnEliminarSeleccionado.Location = new System.Drawing.Point(95, 275);
            this.btnEliminarSeleccionado.Name = "btnEliminarSeleccionado";
            this.btnEliminarSeleccionado.Size = new System.Drawing.Size(29, 28);
            this.btnEliminarSeleccionado.TabIndex = 87;
            this.btnEliminarSeleccionado.UseVisualStyleBackColor = true;
            this.btnEliminarSeleccionado.Click += new System.EventHandler(this.btnEliminarSeleccionado_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::TrabajoPractico.Properties.Resources.search_24x24;
            this.btnBuscar.Location = new System.Drawing.Point(145, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(43, 27);
            this.btnBuscar.TabIndex = 86;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(10, 51);
            this.txtBuscar.MaxLength = 200;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(129, 20);
            this.txtBuscar.TabIndex = 85;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvNotebooks
            // 
            this.dgvNotebooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotebooks.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dgvNotebooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotebooks.Location = new System.Drawing.Point(10, 89);
            this.dgvNotebooks.Name = "dgvNotebooks";
            this.dgvNotebooks.Size = new System.Drawing.Size(510, 180);
            this.dgvNotebooks.TabIndex = 4;
            this.dgvNotebooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotebooks_CellContentClick);
            // 
            // FormTipoNotebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 595);
            this.Controls.Add(this.pnlModelos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTipoNotebook";
            this.Text = "Notebooks";
            this.Load += new System.EventHandler(this.FormTipoNotebook_Load);
            this.pnlModelos.ResumeLayout(false);
            this.pnlModelos.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotebooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlModelos;
        private System.Windows.Forms.DataGridView dgvNotebooks;
        private System.Windows.Forms.Label lblMarcaTipo;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Button btnGuardarNotebooks;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbTipoMarcas;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarSeleccionado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnTiposMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
    }
}