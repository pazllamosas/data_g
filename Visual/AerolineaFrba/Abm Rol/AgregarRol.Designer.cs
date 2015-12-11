namespace AerolineaFrba.Abm_Rol
{
    partial class AgregarRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarRol));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvElegirFuncionalidad = new System.Windows.Forms.DataGridView();
            this.nroFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolFuncionalidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtidRol = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElegirFuncionalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(230, 23);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvElegirFuncionalidad
            // 
            this.dgvElegirFuncionalidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvElegirFuncionalidad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvElegirFuncionalidad.BackgroundColor = System.Drawing.Color.White;
            this.dgvElegirFuncionalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElegirFuncionalidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroFunc,
            this.rolFuncionalidades});
            this.dgvElegirFuncionalidad.Enabled = false;
            this.dgvElegirFuncionalidad.GridColor = System.Drawing.SystemColors.Menu;
            this.dgvElegirFuncionalidad.Location = new System.Drawing.Point(13, 133);
            this.dgvElegirFuncionalidad.Margin = new System.Windows.Forms.Padding(4);
            this.dgvElegirFuncionalidad.Name = "dgvElegirFuncionalidad";
            this.dgvElegirFuncionalidad.RowHeadersWidth = 90;
            this.dgvElegirFuncionalidad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvElegirFuncionalidad.Size = new System.Drawing.Size(493, 297);
            this.dgvElegirFuncionalidad.TabIndex = 4;
            this.dgvElegirFuncionalidad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElegirFuncionalidad_CellContentClick);
            // 
            // nroFunc
            // 
            this.nroFunc.FillWeight = 70F;
            this.nroFunc.HeaderText = "Numero";
            this.nroFunc.Name = "nroFunc";
            this.nroFunc.ReadOnly = true;
            this.nroFunc.Width = 83;
            // 
            // rolFuncionalidades
            // 
            this.rolFuncionalidades.FillWeight = 70F;
            this.rolFuncionalidades.HeaderText = "Funcionalidad";
            this.rolFuncionalidades.Name = "rolFuncionalidades";
            this.rolFuncionalidades.Width = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Elige de a una las funcionalidades que podrá utilizar este rol:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::AerolineaFrba.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(230, 65);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Crear";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::AerolineaFrba.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(357, 65);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(520, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar Funcionalidad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Image = global::AerolineaFrba.Properties.Resources.modify;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(613, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Editar Nombre";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Enabled = false;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(520, 364);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Eliminar Funcionalidad";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtidRol
            // 
            this.txtidRol.Location = new System.Drawing.Point(13, 26);
            this.txtidRol.Margin = new System.Windows.Forms.Padding(4);
            this.txtidRol.Name = "txtidRol";
            this.txtidRol.ReadOnly = true;
            this.txtidRol.Size = new System.Drawing.Size(56, 22);
            this.txtidRol.TabIndex = 9;
            // 
            // labelUsuario
            // 
            this.labelUsuario.Enabled = false;
            this.labelUsuario.Location = new System.Drawing.Point(545, 171);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(70, 24);
            this.labelUsuario.TabIndex = 22;
            this.labelUsuario.Text = "Usuario:";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Enabled = false;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(642, 172);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(132, 24);
            this.cmbUsuario.TabIndex = 26;
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAsignar.Enabled = false;
            this.btnAsignar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsignar.Location = new System.Drawing.Point(588, 231);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(132, 40);
            this.btnAsignar.TabIndex = 27;
            this.btnAsignar.Text = "Asignar Usuario";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Image = global::AerolineaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(732, 386);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(80, 28);
            this.btnVolver.TabIndex = 28;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // AgregarRol
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(845, 446);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.txtidRol);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvElegirFuncionalidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarRol";
            this.Text = "Agregar Rol";
            this.Load += new System.EventHandler(this.AgregarRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElegirFuncionalidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvElegirFuncionalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtidRol;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolFuncionalidades;
        private System.Windows.Forms.Button btnVolver;
    }
}