namespace AerolineaFrba.Abm_Ruta
{
    partial class AgregarRuta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarRuta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioEncomienda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioPasaje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbCiudadOrigen = new System.Windows.Forms.ComboBox();
            this.cmbCiudadDestino = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de ruta:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio de encomienda:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPrecioEncomienda
            // 
            this.txtPrecioEncomienda.Location = new System.Drawing.Point(199, 97);
            this.txtPrecioEncomienda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioEncomienda.Name = "txtPrecioEncomienda";
            this.txtPrecioEncomienda.Size = new System.Drawing.Size(132, 22);
            this.txtPrecioEncomienda.TabIndex = 3;
            this.txtPrecioEncomienda.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "por Kg";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio de pasaje:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPrecioPasaje
            // 
            this.txtPrecioPasaje.Location = new System.Drawing.Point(199, 129);
            this.txtPrecioPasaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioPasaje.Name = "txtPrecioPasaje";
            this.txtPrecioPasaje.Size = new System.Drawing.Size(132, 22);
            this.txtPrecioPasaje.TabIndex = 6;
            this.txtPrecioPasaje.TextChanged += new System.EventHandler(this.txtPrecioPasaje_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ciudad de destino:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ciudad de origen:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::AerolineaFrba.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(729, 402);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(16, 402);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCiudadOrigen
            // 
            this.cmbCiudadOrigen.FormattingEnabled = true;
            this.cmbCiudadOrigen.Location = new System.Drawing.Point(199, 161);
            this.cmbCiudadOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCiudadOrigen.Name = "cmbCiudadOrigen";
            this.cmbCiudadOrigen.Size = new System.Drawing.Size(132, 24);
            this.cmbCiudadOrigen.TabIndex = 13;
            this.cmbCiudadOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbCiudadOrigen_SelectedIndexChanged);
            // 
            // cmbCiudadDestino
            // 
            this.cmbCiudadDestino.FormattingEnabled = true;
            this.cmbCiudadDestino.Location = new System.Drawing.Point(199, 194);
            this.cmbCiudadDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCiudadDestino.Name = "cmbCiudadDestino";
            this.cmbCiudadDestino.Size = new System.Drawing.Size(132, 24);
            this.cmbCiudadDestino.TabIndex = 14;
            this.cmbCiudadDestino.SelectedIndexChanged += new System.EventHandler(this.cmbCiudadDestino_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipo de servicio:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Location = new System.Drawing.Point(199, 64);
            this.cmbTipoServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(132, 24);
            this.cmbTipoServicio.TabIndex = 16;
            this.cmbTipoServicio.SelectedIndexChanged += new System.EventHandler(this.cmbTipoServicio_SelectedIndexChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(199, 32);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(674, 13);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(132, 22);
            this.txtid.TabIndex = 17;
            this.txtid.Visible = false;
            // 
            // AgregarRuta
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(845, 446);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cmbTipoServicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCiudadDestino);
            this.Controls.Add(this.cmbCiudadOrigen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecioPasaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioEncomienda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AgregarRuta";
            this.Text = "Agregar Ruta";
            this.Load += new System.EventHandler(this.AgregarRuta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecioEncomienda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioPasaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbCiudadOrigen;
        private System.Windows.Forms.ComboBox cmbCiudadDestino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtid;
    }
}