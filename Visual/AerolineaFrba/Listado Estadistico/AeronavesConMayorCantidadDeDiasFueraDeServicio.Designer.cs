﻿namespace AerolineaFrba.Listado_Estadistico
{
    partial class AeronavesConMayorCantidadDeDiasFueraDeServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AeronavesConMayorCantidadDeDiasFueraDeServicio));
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnioAConsultar = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Image = global::AerolineaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(12, 326);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(60, 23);
            this.btnVolver.TabIndex = 30;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvListado.Location = new System.Drawing.Point(12, 60);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(610, 260);
            this.dgvListado.TabIndex = 33;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Aeronave";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dias fuera de servicio";
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Listado:";
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Location = new System.Drawing.Point(141, 12);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(121, 21);
            this.cmbSemestre.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Seleccione un semestre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ingrese año a consultar:";
            // 
            // txtAnioAConsultar
            // 
            this.txtAnioAConsultar.Location = new System.Drawing.Point(501, 12);
            this.txtAnioAConsultar.Name = "txtAnioAConsultar";
            this.txtAnioAConsultar.Size = new System.Drawing.Size(100, 20);
            this.txtAnioAConsultar.TabIndex = 38;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::AerolineaFrba.Properties.Resources.xchangemiles_large;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(279, 31);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 23);
            this.btnConsultar.TabIndex = 39;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // AeronavesConMayorCantidadDeDiasFueraDeServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtAnioAConsultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSemestre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AeronavesConMayorCantidadDeDiasFueraDeServicio";
            this.Text = "Aeronaves Con Mayor Cantidad De Dias Fuera De Servicio";
            this.Load += new System.EventHandler(this.AeronavesConMayorCantidadDeDiasFueraDeServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnioAConsultar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}