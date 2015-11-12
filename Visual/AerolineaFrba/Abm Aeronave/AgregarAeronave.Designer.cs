namespace AerolineaFrba.Abm_Aeronave
{
    partial class AgregarAeronave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarAeronave));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantButacasPasillo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEspacioEncomienda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantButacasVentana = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad de Butacas (Pasillo):";
            // 
            // txtCantButacasPasillo
            // 
            this.txtCantButacasPasillo.Location = new System.Drawing.Point(176, 6);
            this.txtCantButacasPasillo.Name = "txtCantButacasPasillo";
            this.txtCantButacasPasillo.Size = new System.Drawing.Size(100, 20);
            this.txtCantButacasPasillo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Espacio para Encomiendas (Kg):";
            // 
            // txtEspacioEncomienda
            // 
            this.txtEspacioEncomienda.Location = new System.Drawing.Point(176, 32);
            this.txtEspacioEncomienda.Name = "txtEspacioEncomienda";
            this.txtEspacioEncomienda.Size = new System.Drawing.Size(100, 20);
            this.txtEspacioEncomienda.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fabricante:";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(176, 58);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(100, 20);
            this.txtFabricante.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cantidad de Butacas (Ventanilla):";
            // 
            // txtCantButacasVentana
            // 
            this.txtCantButacasVentana.Location = new System.Drawing.Point(468, 6);
            this.txtCantButacasVentana.Name = "txtCantButacasVentana";
            this.txtCantButacasVentana.Size = new System.Drawing.Size(100, 20);
            this.txtCantButacasVentana.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::AerolineaFrba.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(12, 130);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::AerolineaFrba.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(496, 130);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Número de Patente:";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(468, 61);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ciudad de Origen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Servicio Brindado:";
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Location = new System.Drawing.Point(468, 32);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoServicio.TabIndex = 24;
            this.cmbTipoServicio.SelectedIndexChanged += new System.EventHandler(this.cmbTipoServicio_SelectedIndexChanged);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(176, 84);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(100, 21);
            this.cmbOrigen.TabIndex = 25;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged);
            // 
            // AgregarAeronave
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(580, 165);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.cmbTipoServicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantButacasVentana);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEspacioEncomienda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantButacasPasillo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarAeronave";
            this.Text = "Agregar Aeronave";
            this.Load += new System.EventHandler(this.AgregarAeronave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantButacasPasillo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEspacioEncomienda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantButacasVentana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.ComboBox cmbOrigen;
    }
}