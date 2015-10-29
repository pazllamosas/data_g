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
            this.dtmFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtmFechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.dtmFechaLlegadaEstimada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deslogearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarAeronave = new System.Windows.Forms.Button();
            this.btnAgregarRuta = new System.Windows.Forms.Button();
            this.dgvVerViaje = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerViaje)).BeginInit();
            this.SuspendLayout();
            // 
            // dtmFechaSalida
            // 
            this.dtmFechaSalida.Location = new System.Drawing.Point(160, 27);
            this.dtmFechaSalida.Name = "dtmFechaSalida";
            this.dtmFechaSalida.Size = new System.Drawing.Size(210, 20);
            this.dtmFechaSalida.TabIndex = 0;
            // 
            // dtmFechaLlegada
            // 
            this.dtmFechaLlegada.Location = new System.Drawing.Point(160, 53);
            this.dtmFechaLlegada.Name = "dtmFechaLlegada";
            this.dtmFechaLlegada.Size = new System.Drawing.Size(210, 20);
            this.dtmFechaLlegada.TabIndex = 1;
            // 
            // dtmFechaLlegadaEstimada
            // 
            this.dtmFechaLlegadaEstimada.Location = new System.Drawing.Point(160, 79);
            this.dtmFechaLlegadaEstimada.Name = "dtmFechaLlegadaEstimada";
            this.dtmFechaLlegadaEstimada.Size = new System.Drawing.Size(210, 20);
            this.dtmFechaLlegadaEstimada.TabIndex = 2;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Llegada Estimada:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
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
            this.btnAgregarAeronave.Location = new System.Drawing.Point(15, 112);
            this.btnAgregarAeronave.Name = "btnAgregarAeronave";
            this.btnAgregarAeronave.Size = new System.Drawing.Size(116, 23);
            this.btnAgregarAeronave.TabIndex = 10;
            this.btnAgregarAeronave.Text = "Agregar Aeronave";
            this.btnAgregarAeronave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarAeronave.UseVisualStyleBackColor = true;
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.Image = global::AerolineaFrba.Properties.Resources.add;
            this.btnAgregarRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRuta.Location = new System.Drawing.Point(160, 112);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(124, 23);
            this.btnAgregarRuta.TabIndex = 11;
            this.btnAgregarRuta.Text = "Agregar Ruta Aerea";
            this.btnAgregarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarRuta.UseVisualStyleBackColor = true;
            // 
            // dgvVerViaje
            // 
            this.dgvVerViaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerViaje.Location = new System.Drawing.Point(15, 141);
            this.dgvVerViaje.Name = "dgvVerViaje";
            this.dgvVerViaje.Size = new System.Drawing.Size(461, 146);
            this.dgvVerViaje.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(15, 336);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::AerolineaFrba.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(401, 336);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // GenerarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 371);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvVerViaje);
            this.Controls.Add(this.btnAgregarRuta);
            this.Controls.Add(this.btnAgregarAeronave);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtmFechaLlegadaEstimada);
            this.Controls.Add(this.dtmFechaLlegada);
            this.Controls.Add(this.dtmFechaSalida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerarViaje";
            this.Text = "Generar Viaje";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerViaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtmFechaSalida;
        private System.Windows.Forms.DateTimePicker dtmFechaLlegada;
        private System.Windows.Forms.DateTimePicker dtmFechaLlegadaEstimada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deslogearToolStripMenuItem;
        private System.Windows.Forms.Button btnAgregarAeronave;
        private System.Windows.Forms.Button btnAgregarRuta;
        private System.Windows.Forms.DataGridView dgvVerViaje;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}