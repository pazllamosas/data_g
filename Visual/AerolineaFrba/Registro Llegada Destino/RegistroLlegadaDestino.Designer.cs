namespace AerolineaFrba.Registro_Llegada_Destino
{
    partial class RegistroLlegadaDestino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroLlegadaDestino));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deslogearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAeropuertoOrigen = new System.Windows.Forms.ComboBox();
            this.cmbAeropuertoDestino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipoServicio = new System.Windows.Forms.TextBox();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCapacidadEncomienda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantButacas = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula de aeronave:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 1;
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
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(154, 64);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(121, 20);
            this.txtMatricula.TabIndex = 2;
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtMatricula_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ciudad de origen:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbAeropuertoOrigen
            // 
            this.cmbAeropuertoOrigen.FormattingEnabled = true;
            this.cmbAeropuertoOrigen.Location = new System.Drawing.Point(154, 90);
            this.cmbAeropuertoOrigen.Name = "cmbAeropuertoOrigen";
            this.cmbAeropuertoOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbAeropuertoOrigen.TabIndex = 4;
            this.cmbAeropuertoOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbAeropuertoOrigen_SelectedIndexChanged);
            // 
            // cmbAeropuertoDestino
            // 
            this.cmbAeropuertoDestino.FormattingEnabled = true;
            this.cmbAeropuertoDestino.Location = new System.Drawing.Point(154, 118);
            this.cmbAeropuertoDestino.Name = "cmbAeropuertoDestino";
            this.cmbAeropuertoDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbAeropuertoDestino.TabIndex = 6;
            this.cmbAeropuertoDestino.SelectedIndexChanged += new System.EventHandler(this.cmbAeropuertoDestino_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ciudad de destino:";
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Image = global::AerolineaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(15, 35);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(58, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de Servicio:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTipoServicio
            // 
            this.txtTipoServicio.Enabled = false;
            this.txtTipoServicio.Location = new System.Drawing.Point(154, 173);
            this.txtTipoServicio.Name = "txtTipoServicio";
            this.txtTipoServicio.Size = new System.Drawing.Size(121, 20);
            this.txtTipoServicio.TabIndex = 9;
            this.txtTipoServicio.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFabricante
            // 
            this.txtFabricante.Enabled = false;
            this.txtFabricante.Location = new System.Drawing.Point(154, 200);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(121, 20);
            this.txtFabricante.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fabricante:";
            // 
            // txtCapacidadEncomienda
            // 
            this.txtCapacidadEncomienda.Enabled = false;
            this.txtCapacidadEncomienda.Location = new System.Drawing.Point(457, 200);
            this.txtCapacidadEncomienda.Name = "txtCapacidadEncomienda";
            this.txtCapacidadEncomienda.Size = new System.Drawing.Size(121, 20);
            this.txtCapacidadEncomienda.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Capacidad de Encomiendas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(584, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "kg";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::AerolineaFrba.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(547, 327);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "fecha de Llegada:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "hora de Llegada:";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(408, 95);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(26, 20);
            this.txtHora.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(481, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = ":";
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(497, 95);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(26, 20);
            this.txtMinutos.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(529, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "(minutos)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(440, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "(horas)";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::AerolineaFrba.Properties.Resources.return_large;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(318, 121);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 25);
            this.btnConsultar.TabIndex = 28;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(414, 64);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(90, 20);
            this.txtFecha.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(510, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "(formato: dd/mm/aaaa)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad de Butacas:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCantButacas
            // 
            this.txtCantButacas.Enabled = false;
            this.txtCantButacas.Location = new System.Drawing.Point(457, 173);
            this.txtCantButacas.Name = "txtCantButacas";
            this.txtCantButacas.Size = new System.Drawing.Size(121, 20);
            this.txtCantButacas.TabIndex = 13;
            // 
            // RegistroLlegadaDestino
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(634, 362);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCapacidadEncomienda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCantButacas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTipoServicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cmbAeropuertoDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAeropuertoOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroLlegadaDestino";
            this.Text = "Registro de Llegada a Destino";
            this.Load += new System.EventHandler(this.RegistroLlegadaDestino_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deslogearToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAeropuertoOrigen;
        private System.Windows.Forms.ComboBox cmbAeropuertoDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTipoServicio;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCapacidadEncomienda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantButacas;
    }
}