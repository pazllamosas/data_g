namespace AerolineaFrba.Abm_Aeronave
{
    partial class VerAeronaves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerAeronaves));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deslogearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAeronaves = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.aeroFechaDeAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroKgDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroFabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroIdServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroCantidadButacas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAeronaves)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::AerolineaFrba.Properties.Resources.add;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(437, 33);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 28);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(845, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deslogearToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // deslogearToolStripMenuItem
            // 
            this.deslogearToolStripMenuItem.Name = "deslogearToolStripMenuItem";
            this.deslogearToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.deslogearToolStripMenuItem.Text = "Salir";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = global::AerolineaFrba.Properties.Resources.delete;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(740, 33);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 28);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::AerolineaFrba.Properties.Resources.modify;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(656, 33);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(76, 28);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Image = global::AerolineaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(13, 33);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(77, 28);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Aeronaves actualmente disponibles:";
            // 
            // dgvAeronaves
            // 
            this.dgvAeronaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAeronaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aeroFechaDeAlta,
            this.aeroMatricula,
            this.aeroModelo,
            this.aeroKgDisponibles,
            this.aeroFabricante,
            this.aeroIdServicio,
            this.aeroCantidadButacas});
            this.dgvAeronaves.Location = new System.Drawing.Point(16, 105);
            this.dgvAeronaves.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAeronaves.Name = "dgvAeronaves";
            this.dgvAeronaves.Size = new System.Drawing.Size(813, 325);
            this.dgvAeronaves.TabIndex = 12;
            this.dgvAeronaves.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAeronaves_CellContentClick);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(329, 33);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(100, 28);
            this.btnSeleccionar.TabIndex = 15;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.Image = global::AerolineaFrba.Properties.Resources.noplane;
            this.btnDarBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDarBaja.Location = new System.Drawing.Point(533, 33);
            this.btnDarBaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(115, 28);
            this.btnDarBaja.TabIndex = 16;
            this.btnDarBaja.Text = "Dar de Baja";
            this.btnDarBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDarBaja.UseVisualStyleBackColor = true;
            this.btnDarBaja.Click += new System.EventHandler(this.btnDarBaja_Click);
            // 
            // aeroFechaDeAlta
            // 
            this.aeroFechaDeAlta.HeaderText = "Fecha de Alta";
            this.aeroFechaDeAlta.Name = "aeroFechaDeAlta";
            // 
            // aeroMatricula
            // 
            this.aeroMatricula.HeaderText = "Matricula";
            this.aeroMatricula.Name = "aeroMatricula";
            // 
            // aeroModelo
            // 
            this.aeroModelo.HeaderText = "Modelo";
            this.aeroModelo.Name = "aeroModelo";
            // 
            // aeroKgDisponibles
            // 
            this.aeroKgDisponibles.HeaderText = "Kg Disponibles";
            this.aeroKgDisponibles.Name = "aeroKgDisponibles";
            // 
            // aeroFabricante
            // 
            this.aeroFabricante.HeaderText = "Fabricante";
            this.aeroFabricante.Name = "aeroFabricante";
            // 
            // aeroIdServicio
            // 
            this.aeroIdServicio.HeaderText = "Servicio";
            this.aeroIdServicio.Name = "aeroIdServicio";
            // 
            // aeroCantidadButacas
            // 
            this.aeroCantidadButacas.HeaderText = "Cantidad de Butacas";
            this.aeroCantidadButacas.Name = "aeroCantidadButacas";
            // 
            // VerAeronaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.btnDarBaja);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvAeronaves);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VerAeronaves";
            this.Text = "Aeronaves";
            this.Load += new System.EventHandler(this.VerAeronaves_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAeronaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deslogearToolStripMenuItem;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAeronaves;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroFechaDeAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroKgDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroIdServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroCantidadButacas;
    }
}