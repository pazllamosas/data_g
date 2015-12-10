namespace AerolineaFrba.Generacion_Viaje
{
    partial class GenerarViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarViaje));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deslogearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarAeronave = new System.Windows.Forms.Button();
            this.btnAgregarRuta = new System.Windows.Forms.Button();
            this.dgvAeronave = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRuta = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFechaLlegada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaSalida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAeronave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha de Llegada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de Salida:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 8;
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
            // btnAgregarAeronave
            // 
            this.btnAgregarAeronave.Image = global::AerolineaFrba.Properties.Resources.add;
            this.btnAgregarAeronave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAeronave.Location = new System.Drawing.Point(94, 112);
            this.btnAgregarAeronave.Name = "btnAgregarAeronave";
            this.btnAgregarAeronave.Size = new System.Drawing.Size(116, 23);
            this.btnAgregarAeronave.TabIndex = 10;
            this.btnAgregarAeronave.Text = "Agregar Aeronave";
            this.btnAgregarAeronave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarAeronave.UseVisualStyleBackColor = true;
            this.btnAgregarAeronave.Click += new System.EventHandler(this.btnAgregarAeronave_Click);
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.Image = global::AerolineaFrba.Properties.Resources.add;
            this.btnAgregarRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRuta.Location = new System.Drawing.Point(387, 112);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(124, 23);
            this.btnAgregarRuta.TabIndex = 11;
            this.btnAgregarRuta.Text = "Agregar Ruta Aerea";
            this.btnAgregarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarRuta.UseVisualStyleBackColor = true;
            this.btnAgregarRuta.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // dgvAeronave
            // 
            this.dgvAeronave.AllowUserToAddRows = false;
            this.dgvAeronave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAeronave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgvAeronave.Location = new System.Drawing.Point(15, 141);
            this.dgvAeronave.Name = "dgvAeronave";
            this.dgvAeronave.ShowRowErrors = false;
            this.dgvAeronave.Size = new System.Drawing.Size(288, 200);
            this.dgvAeronave.TabIndex = 12;
            this.dgvAeronave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerViaje_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Matricula";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Modelo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "KG Disponibles";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fabricante";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Servicio";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cantidad de butacas";
            this.Column6.Name = "Column6";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "ubicacion";
            this.Column13.Name = "Column13";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(12, 360);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::AerolineaFrba.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(501, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(401, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRuta
            // 
            this.dgvRuta.AllowUserToAddRows = false;
            this.dgvRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRuta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvRuta.Location = new System.Drawing.Point(309, 141);
            this.dgvRuta.Name = "dgvRuta";
            this.dgvRuta.ShowRowErrors = false;
            this.dgvRuta.Size = new System.Drawing.Size(267, 200);
            this.dgvRuta.TabIndex = 16;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Codigo";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Precio base (kg)";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Precio base pasaje";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Servicio";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Origen";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Destino";
            this.Column12.Name = "Column12";
            // 
            // txtFechaLlegada
            // 
            this.txtFechaLlegada.Location = new System.Drawing.Point(160, 56);
            this.txtFechaLlegada.Name = "txtFechaLlegada";
            this.txtFechaLlegada.Size = new System.Drawing.Size(90, 20);
            this.txtFechaLlegada.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "(formato: aaaa-mm-dd)";
            // 
            // txtFechaSalida
            // 
            this.txtFechaSalida.Location = new System.Drawing.Point(160, 30);
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.Size = new System.Drawing.Size(90, 20);
            this.txtFechaSalida.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "(formato: aaaa-mm-dd)";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Baja por fuera de servicio";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Fecha reinicio de servicio";
            this.Column15.Name = "Column15";
            // 
            // GenerarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 395);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFechaSalida);
            this.Controls.Add(this.txtFechaLlegada);
            this.Controls.Add(this.dgvRuta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvAeronave);
            this.Controls.Add(this.btnAgregarRuta);
            this.Controls.Add(this.btnAgregarAeronave);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerarViaje";
            this.Text = "Generar Viaje";
            this.Load += new System.EventHandler(this.GenerarViaje_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAeronave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deslogearToolStripMenuItem;
        private System.Windows.Forms.Button btnAgregarAeronave;
        private System.Windows.Forms.Button btnAgregarRuta;
        private System.Windows.Forms.DataGridView dgvAeronave;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridView dgvRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.TextBox txtFechaLlegada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFechaSalida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    }
}