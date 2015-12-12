namespace AerolineaFrba.Abm_Aeronave
{
    partial class reemplazarAeronave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reemplazarAeronave));
            this.label1 = new System.Windows.Forms.Label();
            this.labelButaca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatri = new System.Windows.Forms.TextBox();
            this.txtFab = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtServ = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtButacas = new System.Windows.Forms.TextBox();
            this.txtEncomienda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvAeronaves = new System.Windows.Forms.DataGridView();
            this.aeroFechaDeAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroKgDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroFabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroIdServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroCantidadButacas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroBajaPorFueraServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroFechaFueraDeServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroFechaReinicioDeServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAeronaves)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Esta es su aeronave";
            // 
            // labelButaca
            // 
            this.labelButaca.AutoSize = true;
            this.labelButaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelButaca.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelButaca.Location = new System.Drawing.Point(22, 57);
            this.labelButaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelButaca.Name = "labelButaca";
            this.labelButaca.Size = new System.Drawing.Size(65, 17);
            this.labelButaca.TabIndex = 8;
            this.labelButaca.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fabricante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(681, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(245, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(247, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Origen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(440, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Butacas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(440, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Encomienda";
            // 
            // txtMatri
            // 
            this.txtMatri.Location = new System.Drawing.Point(105, 57);
            this.txtMatri.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatri.Name = "txtMatri";
            this.txtMatri.ReadOnly = true;
            this.txtMatri.Size = new System.Drawing.Size(108, 22);
            this.txtMatri.TabIndex = 15;
            // 
            // txtFab
            // 
            this.txtFab.Location = new System.Drawing.Point(105, 90);
            this.txtFab.Margin = new System.Windows.Forms.Padding(4);
            this.txtFab.Name = "txtFab";
            this.txtFab.ReadOnly = true;
            this.txtFab.Size = new System.Drawing.Size(108, 22);
            this.txtFab.TabIndex = 16;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(743, 60);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(108, 22);
            this.txtModelo.TabIndex = 17;
            // 
            // txtServ
            // 
            this.txtServ.Location = new System.Drawing.Point(306, 57);
            this.txtServ.Margin = new System.Windows.Forms.Padding(4);
            this.txtServ.Name = "txtServ";
            this.txtServ.ReadOnly = true;
            this.txtServ.Size = new System.Drawing.Size(108, 22);
            this.txtServ.TabIndex = 18;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(306, 90);
            this.txtOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.ReadOnly = true;
            this.txtOrigen.Size = new System.Drawing.Size(108, 22);
            this.txtOrigen.TabIndex = 19;
            // 
            // txtButacas
            // 
            this.txtButacas.Location = new System.Drawing.Point(538, 57);
            this.txtButacas.Margin = new System.Windows.Forms.Padding(4);
            this.txtButacas.Name = "txtButacas";
            this.txtButacas.ReadOnly = true;
            this.txtButacas.Size = new System.Drawing.Size(108, 22);
            this.txtButacas.TabIndex = 20;
            // 
            // txtEncomienda
            // 
            this.txtEncomienda.Location = new System.Drawing.Point(538, 90);
            this.txtEncomienda.Margin = new System.Windows.Forms.Padding(4);
            this.txtEncomienda.Name = "txtEncomienda";
            this.txtEncomienda.ReadOnly = true;
            this.txtEncomienda.Size = new System.Drawing.Size(108, 22);
            this.txtEncomienda.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(13, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Elija una aeronave";
            // 
            // dgvAeronaves
            // 
            this.dgvAeronaves.AllowUserToAddRows = false;
            this.dgvAeronaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAeronaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aeroFechaDeAlta,
            this.aeroMatricula,
            this.aeroModelo,
            this.aeroKgDisponibles,
            this.aeroFabricante,
            this.aeroIdServicio,
            this.aeroCantidadButacas,
            this.aeroEstado,
            this.aeroBajaPorFueraServicio,
            this.aeroFechaFueraDeServicio,
            this.aeroFechaReinicioDeServicio,
            this.Column1,
            this.Column2});
            this.dgvAeronaves.Location = new System.Drawing.Point(13, 154);
            this.dgvAeronaves.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAeronaves.Name = "dgvAeronaves";
            this.dgvAeronaves.Size = new System.Drawing.Size(856, 296);
            this.dgvAeronaves.TabIndex = 23;
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
            // aeroEstado
            // 
            this.aeroEstado.HeaderText = "Estado";
            this.aeroEstado.Name = "aeroEstado";
            // 
            // aeroBajaPorFueraServicio
            // 
            this.aeroBajaPorFueraServicio.HeaderText = "Baja por Fuera de Servicio";
            this.aeroBajaPorFueraServicio.Name = "aeroBajaPorFueraServicio";
            // 
            // aeroFechaFueraDeServicio
            // 
            this.aeroFechaFueraDeServicio.HeaderText = "Fecha de Fuera de Servicio";
            this.aeroFechaFueraDeServicio.Name = "aeroFechaFueraDeServicio";
            // 
            // aeroFechaReinicioDeServicio
            // 
            this.aeroFechaReinicioDeServicio.HeaderText = "Fecha de Reinicio de Servicio";
            this.aeroFechaReinicioDeServicio.Name = "aeroFechaReinicioDeServicio";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ubicación";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Baja por vida útil";
            this.Column2.Name = "Column2";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::AerolineaFrba.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(203, 462);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 28);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Reemplazar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::AerolineaFrba.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(534, 462);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 28);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(701, 90);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(108, 22);
            this.txtId.TabIndex = 26;
            this.txtId.Visible = false;
            // 
            // reemplazarAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvAeronaves);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEncomienda);
            this.Controls.Add(this.txtButacas);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtServ);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtFab);
            this.Controls.Add(this.txtMatri);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelButaca);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reemplazarAeronave";
            this.Text = "Reemplazar Aeronave";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAeronaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelButaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatri;
        private System.Windows.Forms.TextBox txtFab;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtServ;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtButacas;
        private System.Windows.Forms.TextBox txtEncomienda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvAeronaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroFechaDeAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroKgDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroIdServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroCantidadButacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroBajaPorFueraServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroFechaFueraDeServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroFechaReinicioDeServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtId;
    }
}