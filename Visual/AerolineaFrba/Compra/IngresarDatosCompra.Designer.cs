namespace AerolineaFrba.Compra
{
    partial class IngresarDatosCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarDatosCompra));
            this.dtmVuelo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCiudadOrigen = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deslogearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbCiudadDestino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantPasajes = new System.Windows.Forms.TextBox();
            this.txtPesoEncomienda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvVuelos = new System.Windows.Forms.DataGridView();
            this.NroVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnBuscarVuelos = new System.Windows.Forms.Button();
            this.dgvPasajes = new System.Windows.Forms.DataGridView();
            this.campraDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campraNumButaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraTipoButaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campraPisoButaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtmVuelo
            // 
            this.dtmVuelo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmVuelo.Location = new System.Drawing.Point(126, 62);
            this.dtmVuelo.MinDate = new System.DateTime(2015, 10, 31, 0, 0, 0, 0);
            this.dtmVuelo.Name = "dtmVuelo";
            this.dtmVuelo.Size = new System.Drawing.Size(121, 20);
            this.dtmVuelo.TabIndex = 0;
            this.dtmVuelo.Value = new System.DateTime(2015, 10, 31, 0, 0, 0, 0);
            this.dtmVuelo.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha del vuelo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ciudad de origen:";
            // 
            // cmbCiudadOrigen
            // 
            this.cmbCiudadOrigen.FormattingEnabled = true;
            this.cmbCiudadOrigen.Location = new System.Drawing.Point(126, 88);
            this.cmbCiudadOrigen.Name = "cmbCiudadOrigen";
            this.cmbCiudadOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudadOrigen.TabIndex = 3;
            this.cmbCiudadOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbCiudadOrigen_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deslogearToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // deslogearToolStripMenuItem
            // 
            this.deslogearToolStripMenuItem.Name = "deslogearToolStripMenuItem";
            this.deslogearToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.deslogearToolStripMenuItem.Text = "Salir";
            // 
            // cmbCiudadDestino
            // 
            this.cmbCiudadDestino.FormattingEnabled = true;
            this.cmbCiudadDestino.Location = new System.Drawing.Point(126, 117);
            this.cmbCiudadDestino.Name = "cmbCiudadDestino";
            this.cmbCiudadDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudadDestino.TabIndex = 9;
            this.cmbCiudadDestino.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ciudad de destino:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cantidad de Pasajes:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCantPasajes
            // 
            this.txtCantPasajes.Location = new System.Drawing.Point(436, 61);
            this.txtCantPasajes.Name = "txtCantPasajes";
            this.txtCantPasajes.Size = new System.Drawing.Size(121, 20);
            this.txtCantPasajes.TabIndex = 14;
            this.txtCantPasajes.TextChanged += new System.EventHandler(this.txtCantPasajes_TextChanged);
            // 
            // txtPesoEncomienda
            // 
            this.txtPesoEncomienda.Location = new System.Drawing.Point(436, 88);
            this.txtPesoEncomienda.Name = "txtPesoEncomienda";
            this.txtPesoEncomienda.Size = new System.Drawing.Size(121, 20);
            this.txtPesoEncomienda.TabIndex = 16;
            this.txtPesoEncomienda.TextChanged += new System.EventHandler(this.txtPesoEncomienda_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Peso de Encomienda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "kg";
            // 
            // dgvVuelos
            // 
            this.dgvVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroVuelo,
            this.FechaPartida});
            this.dgvVuelos.Location = new System.Drawing.Point(12, 164);
            this.dgvVuelos.Name = "dgvVuelos";
            this.dgvVuelos.Size = new System.Drawing.Size(300, 157);
            this.dgvVuelos.TabIndex = 18;
            this.dgvVuelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVuelos_CellContentClick);
            // 
            // NroVuelo
            // 
            this.NroVuelo.Frozen = true;
            this.NroVuelo.HeaderText = "Número de Vuelo";
            this.NroVuelo.Name = "NroVuelo";
            this.NroVuelo.ReadOnly = true;
            // 
            // FechaPartida
            // 
            this.FechaPartida.Frozen = true;
            this.FechaPartida.HeaderText = "Fecha de Partida";
            this.FechaPartida.Name = "FechaPartida";
            this.FechaPartida.ReadOnly = true;
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Image = global::AerolineaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(12, 30);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(58, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Image = global::AerolineaFrba.Properties.Resources.next;
            this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiguiente.Location = new System.Drawing.Point(552, 327);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(70, 23);
            this.btnSiguiente.TabIndex = 19;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnBuscarVuelos
            // 
            this.btnBuscarVuelos.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBuscarVuelos.Enabled = false;
            this.btnBuscarVuelos.Image = global::AerolineaFrba.Properties.Resources.plane;
            this.btnBuscarVuelos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarVuelos.Location = new System.Drawing.Point(521, 117);
            this.btnBuscarVuelos.Name = "btnBuscarVuelos";
            this.btnBuscarVuelos.Size = new System.Drawing.Size(101, 23);
            this.btnBuscarVuelos.TabIndex = 12;
            this.btnBuscarVuelos.Text = "Buscar Vuelos";
            this.btnBuscarVuelos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarVuelos.UseVisualStyleBackColor = true;
            this.btnBuscarVuelos.Click += new System.EventHandler(this.btnBuscarVuelos_Click);
            // 
            // dgvPasajes
            // 
            this.dgvPasajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.campraDni,
            this.compraNombre,
            this.campraNumButaca,
            this.compraTipoButaca,
            this.campraPisoButaca});
            this.dgvPasajes.Enabled = false;
            this.dgvPasajes.Location = new System.Drawing.Point(322, 164);
            this.dgvPasajes.Name = "dgvPasajes";
            this.dgvPasajes.Size = new System.Drawing.Size(300, 128);
            this.dgvPasajes.TabIndex = 21;
            this.dgvPasajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasajes_CellContentClick);
            // 
            // campraDni
            // 
            this.campraDni.HeaderText = "DNI";
            this.campraDni.Name = "campraDni";
            // 
            // compraNombre
            // 
            this.compraNombre.HeaderText = "Nombre";
            this.compraNombre.Name = "compraNombre";
            // 
            // campraNumButaca
            // 
            this.campraNumButaca.HeaderText = "Numero de Butaca";
            this.campraNumButaca.Name = "campraNumButaca";
            // 
            // compraTipoButaca
            // 
            this.compraTipoButaca.HeaderText = "Tipo de Butaca";
            this.compraTipoButaca.Name = "compraTipoButaca";
            // 
            // campraPisoButaca
            // 
            this.campraPisoButaca.HeaderText = "Piso";
            this.campraPisoButaca.Name = "campraPisoButaca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Seleccione un vuelo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Elija sus butacas:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Image = global::AerolineaFrba.Properties.Resources.add;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(533, 298);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 23);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Elegir Butaca";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::AerolineaFrba.Properties.Resources.modify;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(435, 298);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 23);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar Pasaje";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // IngresarDatosCompra
            // 
            this.AcceptButton = this.btnSiguiente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(634, 362);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvPasajes);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.dgvVuelos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPesoEncomienda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantPasajes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarVuelos);
            this.Controls.Add(this.cmbCiudadDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cmbCiudadOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtmVuelo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IngresarDatosCompra";
            this.Text = "Comprar";
            this.Load += new System.EventHandler(this.IngresarDatosCompra_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtmVuelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCiudadOrigen;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deslogearToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbCiudadDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarVuelos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantPasajes;
        private System.Windows.Forms.TextBox txtPesoEncomienda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvVuelos;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.DataGridView dgvPasajes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn campraDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn compraNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn campraNumButaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn compraTipoButaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn campraPisoButaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPartida;
    }
}