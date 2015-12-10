namespace AerolineaFrba.Compra
{
    partial class ElegirButaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElegirButaca));
            this.dgvSeleccionButaca = new System.Windows.Forms.DataGridView();
            this.butacaNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butacaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butacaPiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butacaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionButaca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSeleccionButaca
            // 
            this.dgvSeleccionButaca.AllowUserToAddRows = false;
            this.dgvSeleccionButaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionButaca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.butacaNro,
            this.butacaTipo,
            this.butacaPiso,
            this.butacaEstado});
            this.dgvSeleccionButaca.Location = new System.Drawing.Point(12, 146);
            this.dgvSeleccionButaca.Name = "dgvSeleccionButaca";
            this.dgvSeleccionButaca.Size = new System.Drawing.Size(610, 177);
            this.dgvSeleccionButaca.TabIndex = 9;
            this.dgvSeleccionButaca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeleccionButaca_CellContentClick);
            // 
            // butacaNro
            // 
            this.butacaNro.HeaderText = "Numero de Butaca";
            this.butacaNro.Name = "butacaNro";
            // 
            // butacaTipo
            // 
            this.butacaTipo.HeaderText = "Tipo de Butaca";
            this.butacaTipo.Name = "butacaTipo";
            // 
            // butacaPiso
            // 
            this.butacaPiso.HeaderText = "Piso";
            this.butacaPiso.Name = "butacaPiso";
            // 
            // butacaEstado
            // 
            this.butacaEstado.HeaderText = "Estado";
            this.butacaEstado.Name = "butacaEstado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seleccione la/s butaca/s en las que desee viajar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::AerolineaFrba.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(547, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
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
            this.btnGuardar.Location = new System.Drawing.Point(12, 329);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(133, 12);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(121, 20);
            this.txtDni.TabIndex = 16;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "DNI:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre:";
            // 
            // ElegirButaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 362);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSeleccionButaca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ElegirButaca";
            this.Text = "Seleccionar Butacas";
            this.Load += new System.EventHandler(this.ElegirButaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionButaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSeleccionButaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn butacaNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn butacaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn butacaPiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn butacaEstado;
    }
}